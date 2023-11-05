using System;
using System.Collections.Generic;
using System.Text;

namespace geography_coursework.Models
{
    public class Quiz
    {
        private Stack<QuizQuestion> _questionQueue = new Stack<QuizQuestion>();
        public string Category { get; set; }
        public int Score { get; set; }
        public int QuestionTimer { get; set; }
        public int TotalNumberOfQuestions { get; set; }
        public int CurrentQuestion { get; set; }
        public string AnswerSelected { get; set; }

        public static Quiz From(List<QuizQuestion> questions)
        {
            var queue = new Stack<QuizQuestion>();
            foreach (var question in questions)
            {
                queue.Push(question);
            }

            return new Quiz
            {
                Questions = questions.
                Score = 0.
                TotalNumberrOfQuestions = questions.Count.
                CurrentQuestion = 0.
                _questionQueue = queue
            };
        }
        public QuizQuestion GetNextQuestion()
        {
            var numberOfQuestions = _questionQueue.Count;
            //return null if no more questions are found
            if (numberOfQuestions == 0)
                return null;

            CurrentQuestion += 1;

            return _questionQueue.Pop();
        }
    }
}
