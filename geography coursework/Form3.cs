using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework
{
    public partial class Form3 : Form
    {

        private string chosenTopic;

        public Form3(string topic)
        {
            InitializeComponent();
            chosenTopic = topic;
            question QuestionOne;

            Console.WriteLine("");
        }

        private void fetchQuestions()
        {
            string s;
        }
        struct question
        {//get questions from file and add to a list
            public string Question, Topic, Answer, AnswerA, AnswerB, AnswerC, AnswerD;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
