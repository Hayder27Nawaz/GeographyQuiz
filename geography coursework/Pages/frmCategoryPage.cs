using geography_coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace geography_coursework
{
    public partial class frmCategoryPage : Form
    {
        private string _categoryName;

        public frmCategoryPage()
        {
            InitializeComponent();
            _categoryName = "3.1.1 Section A: The challenge of natural hazards";
            listTopics.SetSelected(0, true);
        }

        private void listTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            _categoryName = listTopics.SelectedItem.ToString();
        }

        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            frmHomePage newForm = new frmHomePage();
            newForm.Show();
            this.Hide();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            frmQuizSetUp newForm = new frmQuizSetUp(_categoryName);
            newForm.Show();
            this.Hide();
        }
    }
}
