using geography_coursework.Models;
using geography_coursework.Pages;
using geography_coursework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace geography_coursework
{
    public partial class frmQuizPage : Form
    {
        private Quiz _quiz;
        public frmQuizPage()
        {
            InitializeComponent();
            InitialisePage();
        }

        private void InitialisePage()
        {
            var questions = new FileManager().GetQuestions();
            _quiz = Quiz.From(questions);

            SetQuestion(_quiz.GetNextQuestion());
            UpdateScore();
            UpdateTracker();
        }

        private void UpdateScore()
        {
            lblScore.Text = $"Score:{_quiz.Score}";
        }
        private void UpdateTracker()
        {
            lblQuestionTracker.Text = $"Question {_quiz.CurrentQuestion}/{_quiz.TotalNumberOfQuestions}";
        }

        private void SetQuestion(QuizQuestion quizQuestion)
        {
            lblQuestion.Text = quizQuestion.Question;
            btnOptionA.Text = quizQuestion.OptionA;
            btnOptionB.Text = quizQuestion.OptionB;
            btnOptionC.Text = quizQuestion.OptionC;
            btnOptionD.Text = quizQuestion.OptionD;
        }
        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            frmHomePage newForm = new frmHomePage();
            newForm.Show();
            this.Hide();
        }

        private void btnOptionA_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionB_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionC_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionD_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var question = _quiz.GetNextQuestion();
            if (question is null)
            {
                frmResultsPage newForm = new frmResultsPage();
                newForm.Show();
                this.Hide();

                return;
            }
            SetQuestion(question);
            UpdateScore();
            UpdateTracker();
        }
    }
}
