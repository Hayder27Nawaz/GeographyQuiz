using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework.Pages
{
    public partial class frmResultsPage : Form
    {
        public frmResultsPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStudentHomePage newForm = new frmStudentHomePage();
            newForm.Show();
            this.Hide();
        }
    }
}
