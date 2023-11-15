using App.Models;
using geography_coursework.Interfaces;
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
        private const string EasyDifficulty = "EASY";
        private const string MediumDifficulty = "MEDIUM";
        private const string HardDifficulty = "HARD";

        private readonly IQuiz _quiz;
        private QuizQuestion _currentQuestion;
        private string _selectedAnswer = string.Empty;

        private int _counter;

        public frmQuizPage(IQuiz quiz)
        {
            _quiz = quiz;

            InitializeComponent();
            InitialisePage();
        }

        private void btnOptionA_Click(object sender, EventArgs e)
        {
            ClearSelection();
            _selectedAnswer = btnOptionA.Text;
            btnOptionA.BackColor = SelectedColor();
        }

        private void btnOptionB_Click(object sender, EventArgs e)
        {
            ClearSelection();
            _selectedAnswer = btnOptionB.Text;
            btnOptionB.BackColor = SelectedColor();
        }

        private void btnOptionC_Click(object sender, EventArgs e)
        {
            ClearSelection();
            _selectedAnswer = btnOptionC.Text;
            btnOptionC.BackColor = SelectedColor();
        }

        private void btnOptionD_Click(object sender, EventArgs e)
        {
            ClearSelection();
            _selectedAnswer = btnOptionD.Text;
            btnOptionD.BackColor = SelectedColor();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _quiz.SetAnswer(_currentQuestion, _selectedAnswer);

            var question = _quiz.GetNextQuestion();
            _currentQuestion = question;

            if (question is null)
            {
                var page = new frmResultsPage(_quiz);
                page.Show();
                Hide();

                return;
            }

            ClearSelection();
            DisplayQuestionAndAnswers();
            ResetTimer();
            DisplayScore();
            DisplayTracker();
        }

        private void InitialisePage()
        {
            var question = _quiz.GetNextQuestion();
            _currentQuestion = question;

            SetTitle();
            SetSubmitButtonText();
            ClearSelection();
            DisplayQuestionAndAnswers();
            DisplayScore();
            DisplayTracker();
            SetTimer();
        }

        private void SetTitle()
        {
            Text = $"{_quiz.Type} Quiz";
        }

        private void SetSubmitButtonText()
        {
            btnSubmit.Text = _quiz.IsReviewMode() ? "Next" : "Submit";
        }

        private void DisplayQuestionAndAnswers()
        {
            lblCategory.Text = _currentQuestion.Category;
            lblQuestion.Text = _currentQuestion.Question;
            btnOptionA.Text = _currentQuestion.OptionA;
            btnOptionB.Text = _currentQuestion.OptionB;
            btnOptionC.Text = _currentQuestion.OptionC;
            btnOptionD.Text = _currentQuestion.OptionD;

            DisplayDifficulty(_currentQuestion);

            if (_quiz.IsReviewMode())
            {
                btnOptionA.Enabled = false;
                btnOptionB.Enabled = false;
                btnOptionC.Enabled = false;
                btnOptionD.Enabled = false;

                var currentAnswer = _quiz.GetCurrentAnswer();

                btnOptionA.BackColor = DetermineDisplayColor(btnOptionA, currentAnswer);
                btnOptionB.BackColor = DetermineDisplayColor(btnOptionB, currentAnswer);
                btnOptionC.BackColor = DetermineDisplayColor(btnOptionC, currentAnswer);
                btnOptionD.BackColor = DetermineDisplayColor(btnOptionD, currentAnswer);

                SetResult(currentAnswer);
            }
        }

        private void SetResult(QuizAnswer currentAnswer)
        {
            if (currentAnswer.IsCorrect())
            {
                lblResult.Text = "CORRECT";
                lblResult.ForeColor = Color.Green;
                return;
            }

            if (string.IsNullOrEmpty(currentAnswer.SelectedAnswer))
            {
                lblResult.Text = "SKIPPED";
                lblResult.ForeColor = Color.Orange;
                return;
            }

            lblResult.Text = "INCORRECT";
            lblResult.ForeColor = Color.Red;
        }

        private Color DetermineDisplayColor(System.Windows.Forms.Button button, QuizAnswer currentAnswer)
        {
            var color = UnSelectedColor();

            if (button.Text == currentAnswer.SelectedAnswer && !currentAnswer.IsCorrect())
                color = Color.Red;

            if (button.Text == currentAnswer.Question.Answer)
                color = Color.Green;

            return color;
        }

        private void DisplayDifficulty(QuizQuestion quizQuestion)
        {
            switch (quizQuestion.DifficultyLevel)
            {
                case 20:
                    lblDifficulty.Text = MediumDifficulty;
                    lblDifficulty.ForeColor = Color.Orange;
                    break;
                case 30:
                    lblDifficulty.Text = HardDifficulty;
                    lblDifficulty.ForeColor = Color.Red;
                    break;
                default:
                    lblDifficulty.Text = EasyDifficulty;
                    lblDifficulty.ForeColor = Color.Green;
                    break;
            }
        }

        public void DisplayScore()
        {
            lblResult.Text = $"Score: {_quiz.GetScore()}";
        }

        public void DisplayTracker()
        {
            lblTracker.Text = $"{_quiz.CurrentQuestion}/{_quiz.TotalQuestions}";
        }

        private void ClearSelection()
        {
            btnOptionA.BackColor = UnSelectedColor();
            btnOptionB.BackColor = UnSelectedColor();
            btnOptionC.BackColor = UnSelectedColor();
            btnOptionD.BackColor = UnSelectedColor();
            lblResult.Text = string.Empty;
            _selectedAnswer = string.Empty;
        }

        private void SetTimer()
        {
            if (_quiz.IsTimerEnabled())
            {
                timer1.Interval = 1000;
                timer1.Tick += timer1_Tick;

                _counter = _quiz.TimerCounter;

                SetCounterLabel();
                timer1.Start();
            }
            else
            {
                lblCounter.Text = string.Empty;
            }
        }

        public void ResetTimer()
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }

            if (_quiz.IsTimerEnabled())
            {
                _counter = _quiz.TimerCounter;
                SetCounterLabel();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _counter--;
            SetCounterLabel();

            if (_counter == 0)
            {
                timer1.Stop();
                btnSubmit.PerformClick();
            }
        }

        private void SetCounterLabel()
        {
            lblCounter.Text = _counter.ToString();

            lblCounter.ForeColor = _counter switch
            {
                < 3 => Color.Red,
                < 5 => Color.Orange,
                _ => Color.Black
            };
        }

        private static Color UnSelectedColor() => Color.FromArgb(255, 255, 128);
        private static Color SelectedColor() => Color.FromArgb(192, 255, 192);
    }
}
