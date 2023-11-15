using App.Models;
using geography_coursework.Services;
using geography_coursework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using geography_coursework.Pages;
using geography_coursework.Models;

namespace geography_coursework
{
    public partial class frmHomePage : Form
    {
        private FileService _fileService;

        public frmHomePage()
        {
            InitializeComponent();
            _fileService = new FileService();
        }

        private void btnStartSimpleQuiz_Click(object sender, EventArgs e)
        {
            LoadQuizPage("Simple");
        }

        private void btnStartComplexQuiz_Click(object sender, EventArgs e)
        {
            LoadQuizPage("Complex");
        }

        private void btnStartCustomQuiz_Click(object sender, EventArgs e)
        {
            LoadQuizPage("Custom");
        }

        private void LoadQuizPage(string quizType)
        {
            var name = txtName.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name!", "Error");
                return;
            }

            var questions = LoadQuestions();

            switch (quizType)
            {
                case "Simple":
                    var simpleQuiz = new SimpleQuiz(name, questions);

                    var simpleQuizpage = new frmQuizPage(simpleQuiz);
                    simpleQuizpage.Show();
                    Hide();

                    break;

                case "Complex":
                    var complexQuiz = new ComplexQuiz(name, questions);

                    var customQuizpage = new frmQuizPage(complexQuiz);
                    customQuizpage.Show();
                    Hide();

                    break;

                case "Custom":
                    var customPage = new frmCustomSettingsPage(name, questions);
                    customPage.Show();
                    Hide();

                    break;

                default:
                    MessageBox.Show("Unsupported quiz.  Please contact your administrator.", "Error");
                    return;
            }
        }

        private List<QuizQuestion> LoadQuestions()
        {
            return _fileService.GetQuestions();
        }

        private void btnViewHighscores_Click(object sender, EventArgs e)
        {
            var page = new frmHighscorePage();
            page.Show();
            Hide();
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            var page = new frmSummaryPage();
            page.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnViewSummary_Click_1(object sender, EventArgs e)
        {
            var page = new frmSummaryPage();
            page.Show();
            Hide();
        }

        private void btnViewHighscores_Click_1(object sender, EventArgs e)
        {
            var page = new frmHighscorePage();
            page.Show();
            Hide();
        }
    }
}