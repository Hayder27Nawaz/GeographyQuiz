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
        public frmHighscorePage()
        {
            InitializeComponent();
        }

        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            frmHomePage newForm = new frmHomePage();
            newForm.Show();
            this.Hide();
        }
    }
}
