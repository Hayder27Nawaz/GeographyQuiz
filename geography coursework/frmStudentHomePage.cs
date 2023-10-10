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

        private void QuizStart(object sender, EventArgs e)
        {
            frmCategorySelect newForm = new frmCategorySelect();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
