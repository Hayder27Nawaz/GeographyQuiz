using App.Models;
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
    public partial class frmHighscorePage : Form
    {
        private readonly DataStoreService _dataService;

        public frmHighscorePage()
        {
            _dataService = new DataStoreService();

            InitializeComponent();
            InitialisePage();
        }

        private void InitialisePage()
        {
            lblErrorMessage.Text = string.Empty;

            try
            {
                var highscores = _dataService.GetHighscores("DESC", 10);

                BindData(highscores);
            }
            catch
            {
                lblErrorMessage.Text = "There was an error getting highscores from the database.";
            }
        }

        private void BindData(List<Highscore> highscores)
        {
            dgvHighscores.Rows.Clear();

            foreach (var highscore in highscores)
            {
                dgvHighscores.Rows.Add(highscore.Id, highscore.Username, highscore.Type, highscore.Score.ToString(), highscore.Created.ToString("dd-MM-yyy"));
            }
        }

        private void btnReturnToHome_Click(object sender, EventArgs e)
        {
            var page = new frmHomePage();
            page.Show();
            Hide();
        }

        private void dgvHighscores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvHighscores.Rows[e.RowIndex];
                var id = row.Cells[0].Value;

                if (id != null)
                {
                    var quizId = int.Parse(id.ToString());

                    var quiz = _dataService.GetQuiz(quizId);

                    var page = new frmQuizPage(quiz);
                    page.Show();
                    Hide();
                }
            }
        }
    }
}
