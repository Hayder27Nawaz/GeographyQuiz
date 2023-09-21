using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_geography_quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CONTINUE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 settings = new Form2();
            settings.ShowDialog();
            this.Show();




        }

        private void GeoGame_Click(object sender, EventArgs e)
        {

        }
    }
}
