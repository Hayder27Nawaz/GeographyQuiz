using App.Models;
using geography_coursework.Interfaces;
using geography_coursework.Models;
using geography_coursework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geography_coursework.Pages
{
    public partial class frmResultsPage : Form
    {
        private readonly IQuiz _quiz;
        private readonly DataStoreService _dataService;

        public frmResultsPage(IQuiz quiz)
        {
            _quiz = quiz;
            _dataService = new DataStoreService();

            InitializeComponent();
            InitialisePage();
        }

        private void InitialisePage()
        {
            lblScore.Text = $"Score: {_quiz.GetScore()}";
            lblErrorMessage.Text = string.Empty;

            BindData();

            try
            {
                if (!_quiz.IsReviewMode())
                    _dataService.Save(_quiz);
            }
            catch
            {
                lblErrorMessage.Text = "There was an error saving results to the database.";
            }
        }

        private void BindData()
        {
            dgvResults.Rows.Clear();

            var grouped = _quiz.Answers.GroupBy(gb => gb.Question.Category);

            foreach (var group in grouped)
            {
                var totalNumberOfQuestionsInCategory = _quiz.Answers.Count(a => a.Question.Category == group.Key);
                var totalNumberOfCorrectQuestionsInCategory = _quiz.Answers.Count(a => a.Question.Category == group.Key && a.IsCorrect());

                var score = 0m;

                if (totalNumberOfCorrectQuestionsInCategory != 0)
                    score = decimal.Divide(totalNumberOfCorrectQuestionsInCategory, totalNumberOfQuestionsInCategory) * 100;

                dgvResults.Rows.Add(group.Key, $"{decimal.Round(score, 2, MidpointRounding.AwayFromZero)}%");
            }
        }

        private void btnStartNewQuiz_Click(object sender, EventArgs e)
        {
            var page = new frmHomePage();
            page.Show();
            Hide();
        }

        private void btnReviewAnswers_Click(object sender, EventArgs e)
        {
            var page = new frmQuizPage(new ReviewModeQuiz(_quiz));
            page.Show();
            Hide();
        }
    }
}
