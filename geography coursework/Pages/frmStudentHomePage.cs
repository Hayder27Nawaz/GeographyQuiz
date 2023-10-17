using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework
{
    public partial class frmStudentHomePage : Form
    {
        public frmStudentHomePage()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettingsPage newForm = new frmSettingsPage();
            newForm.Show();
            this.Hide();
        }

        private void btnStartRevising_Click(object sender, EventArgs e)
        {

            frmCategorySelect newForm = new frmCategorySelect();
            newForm.Show();
            this.Hide();
        }

        private void btnPreviousTestResults_Click(object sender, EventArgs e)
        {
            frmPreviousQuizResults newForm = new frmPreviousQuizResults();
            newForm.Show();
            this.Hide();
        }

        private void btnLastRevisionTest_Click(object sender, EventArgs e)
        {
            frmQuizPage newForm = new frmQuizPage();
            newForm.Show();
            this.Hide();
        }

    }
}
