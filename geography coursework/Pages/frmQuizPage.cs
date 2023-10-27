using geography_coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace geography_coursework
{
    public partial class frmQuizPage : Form
    {
        public frmQuizPage()
        {
            InitializeComponent();
        }

        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            frmStudentHomePage newForm = new frmStudentHomePage();
            newForm.Show();
            this.Hide();
        }

        private void btnOptionA_Click(object sender, EventArgs e)
        {
            {
                string filePath = "C:\\Users\\Hayder\\Documents\\GeographyQuiz\\geography coursework\\quiz_questions\\geography_questions.csv;";
                try
                {
                    if (System.IO.File.Exists(filePath))
                    {
                        // Read the content from the file
                        string fileContent = System.IO.File.ReadAllText(filePath);

                        // Display the content in a TextBox (or any other suitable control)
                        btnOptionA.Text = fileContent;
                    }
                    else
                    {
                        MessageBox.Show("File not found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }
    }
}
