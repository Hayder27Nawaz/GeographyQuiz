﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework
{
    public partial class frmSettingsPage : Form
    {
        public frmSettingsPage()
        {
            InitializeComponent();
        }

        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            frmStudentHomePage newForm = new frmStudentHomePage();
            newForm.Show();
            this.Hide();
        }
    }
}
