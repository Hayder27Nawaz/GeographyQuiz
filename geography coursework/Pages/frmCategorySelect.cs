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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace geography_coursework
{
    public partial class frmCategorySelect : Form
    {

        public frmCategorySelect()
        public static List<string[]> LoadCSV(string filePath)//should this replace the line above
        {
            InitializeComponent();
            public static List<string[]> LoadCSV(string filePath)
            {
                List<string[]> data = new List<string[]>();

                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] values = line.Split(',');
                            data.Add(values);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                return data;
            }

            //  Load file
            string filePath = "QuizQuestions.cs";
            List<string[]> csvData = LoadCSV(filePath);

            foreach (string[] row in csvData)
            {
                foreach (string value in row)
                {
                    Console.Write(value + "\t");
                }
                Console.WriteLine();
            }

        }



        private void listTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listTopics.SelectedItem == null || this.listTopics.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a topic");
            }
            else
            {
                SelectedTopic = listTopics.SelectedItem.ToString();
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
}
