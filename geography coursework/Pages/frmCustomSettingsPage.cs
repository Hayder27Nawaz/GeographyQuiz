using App.Models;
using geography_coursework.Models;
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
    public partial class frmCustomSettingsPage : Form
    {
        private readonly string _name;
        private readonly List<QuizQuestion> _questions;
        private int _selectedTimer = -1;
        private int _numberOfQuestions = 10;

        public frmCustomSettingsPage(string name, List<QuizQuestion> questions)
        {
            _name = name;
            _questions = questions;

            InitializeComponent();
            InitialisePage();
        }

        private void InitialisePage()
        {
            SelectAllCategories();

            _selectedTimer = -1;
            btnTimerUnlimited.BackColor = SelectedColor();

            _numberOfQuestions = 10;
            btnQuestions10.BackColor = SelectedColor();
        }

        private void SelectAllCategories()
        {
            for (var count = 0; count < clbCategories.Items.Count; count++)
            {
                clbCategories.SetItemChecked(count, true);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var selectedCategories = new List<string>();

            for (var count = 0; count < clbCategories.CheckedItems.Count; count++)
            {
                selectedCategories.Add(clbCategories.CheckedItems[count].ToString());
            }

            if (selectedCategories.Count == 0)
            {
                MessageBox.Show("Please select at least one category", "Error");
                return;
            }

            var quiz = new CustomQuiz(_name, selectedCategories, _questions, _numberOfQuestions, _selectedTimer);

            var page = new frmQuizPage(quiz);
            page.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var page = new frmHomePage();
            page.Show();
            Hide();
        }

        private void btnTimer10_Click(object sender, EventArgs e)
        {
            ClearTimerSelection();
            _selectedTimer = 10;
            btnTimer10.BackColor = SelectedColor();
        }

        private void btnTimer20_Click(object sender, EventArgs e)
        {
            ClearTimerSelection();
            _selectedTimer = 20;
            btnTimer20.BackColor = SelectedColor();
        }

        private void btnTimerUnlimited_Click(object sender, EventArgs e)
        {
            ClearTimerSelection();
            _selectedTimer = -1;
            btnTimerUnlimited.BackColor = SelectedColor();
        }

        private void btnQuestions10_Click(object sender, EventArgs e)
        {
            ClearQuestionSelection();
            _numberOfQuestions = 10;
            btnQuestions10.BackColor = SelectedColor();
        }

        private void btnQuestions20_Click(object sender, EventArgs e)
        {
            ClearQuestionSelection();
            _numberOfQuestions = 20;
            btnQuestions20.BackColor = SelectedColor();
        }

        private void btnQuestions50_Click(object sender, EventArgs e)
        {
            ClearQuestionSelection();
            _numberOfQuestions = 30;
            btnQuestions50.BackColor = SelectedColor();
        }

        private void ClearTimerSelection()
        {
            btnTimer10.BackColor = UnSelectedColor();
            btnTimer20.BackColor = UnSelectedColor();
            btnTimerUnlimited.BackColor = UnSelectedColor();
        }

        private void ClearQuestionSelection()
        {
            btnQuestions10.BackColor = UnSelectedColor();
            btnQuestions20.BackColor = UnSelectedColor();
            btnQuestions50.BackColor = UnSelectedColor();
        }

        private static Color UnSelectedColor() => Color.FromArgb(240, 240, 240);
        private static Color SelectedColor() => Color.FromArgb(255, 255, 128);

    }

}

