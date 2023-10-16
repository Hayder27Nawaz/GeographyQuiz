using System;
using System.Collections.Generic;
using System.Text;

namespace geography_coursework.Models
{
    internal class Quiz
    {
        public string Category { get; set; }
        public int Score { get; set; }
        public int QuestionTimer { get; set; }
        public int TotalNumberOfQuestions { get; set; }
        public int CurrentQuestion { get; set; }
        public string AnswerSelected { get; set; }
    }
}
