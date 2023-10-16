using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework
{
    public partial class frmCategorySelect : Form
    {
        public frmCategorySelect()
        {
            InitializeComponent();
            //  Load file
        }

        private void listTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get Selected category
            // Get questions assigned to category
            // Start quiz
            // Load/navigate to quiz page
            // Use ChatGPT and google
        }

        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            frmStudentHomePage newForm = new frmStudentHomePage();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuizPage newForm = new frmQuizPage();
            newForm.Show();
            this.Hide();
        }
    }
}
