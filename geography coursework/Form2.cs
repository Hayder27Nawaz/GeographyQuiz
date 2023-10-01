using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TopicSelected(object sender, EventArgs e)

        {//when a topic selected from list update topic and open form

            string SelectedTopic = listTopics.Text;
            if (SelectedTopic != "")
            {
                QuizPage quizForm = new QuizPage(SelectedTopic);
                quizForm.ShowDialog();
                this.Close();
            }


        }

        private void Subjectchooser(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
