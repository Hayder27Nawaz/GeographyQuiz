using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btnLogSignIn_Click(object sender, EventArgs e)
        {
            var signInForm = new frmSignIn();
            signInForm.Show();
            Hide();
        }

    }
}
