using System.Collections.Generic;

namespace geography_coursework.Models

{
    public abstract class QuizBase
    {
        protected static int PointsPerQuestion = 10;
        protected int _score = 0;

        public string Name { get; set; } = string.Empty;
        public int CurrentQuestion { get; set; } = 1;
        public int TotalQuestions { get; set; }
        public System.Collections.Generic.List<QuizAnswer> Answers { get; set; } = new List<QuizAnswer>();

        protected void IncrementCurrentQuestion()
        {
            CurrentQuestion += 1;
        }

        protected void IncrementScore()
        {
            _score += PointsPerQuestion;
        }

        protected int GetScore()
        {
            return _score;
        }
    }
}
