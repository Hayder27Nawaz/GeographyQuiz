using geography_coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework
{
    public partial class QuizPage : Form
    {

        private string chosenTopic;

        public QuizPage(string topic)
        {
            InitializeComponent();
            fetchQuestions();
            chosenTopic = topic;
           // question QuestionOne;
            LoadQuestions();

            Console.WriteLine("");
        }

        private void fetchQuestions()
        {
            var questions = File.ReadAllLines("quiz_questions/geography_questions.csv");
            string s;
        }

        private void LoadQuestions()
        {
            List<QuizQuestion> quizQuestions = new List<QuizQuestion>();

            string[] csvLines = File.ReadAllLines("questions/name_questions.csv");

            foreach (string csvLine in csvLines.Skip(1))
            {
                QuizQuestion quizQuestion = QuizQuestion.From(csvLine);
                quizQuestions.Add(quizQuestion);
            }


            int numberOfQuestions = quizQuestions.Count;

            //var firstQuestion = quizQuestions.First();
            //labelQuestion.Text = firstQuestion.Question;
            //buttonOptionA.Text = firstQuestion.OptionA;
            //buttonOptionB.Text = firstQuestion.OptionB;
        }
    }

        
        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button4_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void buttonB_Click(object sender, EventArgs e)
        //{

        //}
    }

