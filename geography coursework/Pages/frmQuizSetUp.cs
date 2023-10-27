using geography_coursework.Models;
using geography_coursework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework
{
    public partial class frmQuizSetUp : Form
    {
        int seconds = 0;
        private string _categoryName;

        public frmQuizSetUp(string categoryName)
        {
            InitializeComponent();
            _categoryName = categoryName;

            List<QuizQuestion> quizQuestions = new FileService().GetQuestions();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            frmQuizPage newForm = new frmQuizPage();
            newForm.Show();
            this.Hide();
            seconds = 10;
            countdownTimer.Start();
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            lblScreen.Text = seconds--.ToString();
            if (seconds < 0)
                countdownTimer.Stop();
        }
    }
}
