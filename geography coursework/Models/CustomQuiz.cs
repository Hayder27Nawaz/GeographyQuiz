using geography_coursework.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace geography_coursework.Models
{
    public class CustomQuiz : QuizBase, IQuiz
    {
        private readonly List<QuizQuestion> _questions;
        private readonly int _timerCounter;

        private Stack<QuizQuestion> _questionQueue = new();
        private QuizAnswer _currentAnswer;

        public CustomQuiz(string name, List<string> categories, List<QuizQuestion> questions, int numberOfQuestions, int timer)
        {
            _timerCounter = timer;
            _questions = FilterQuestions(questions, categories, numberOfQuestions);

            Name = name;
            TotalQuestions = _questions.Count;

        }

        private List<QuizQuestion> FilterQuestions(List<QuizQuestion> questions, List<string> categories, int numberOfQuestions)
        {
            return questions
                .Where(q => categories.Contains(q.Category))
                .OrderBy(q => q.DifficultyLevel)
                .Take(numberOfQuestions)
                .ToList();
        }

        public bool IsReviewMode()
        {
            return false;
        }

        public bool IsTimerEnabled()
        {
            return _timerCounter > 0;
        }

        public string Type => "Custom";

        public int TimerCounter => _timerCounter;

        List<QuizAnswer> IQuiz.Answers => throw new System.NotImplementedException();

        public QuizQuestion GetNextQuestion()
        {
            if (CurrentQuestion > TotalQuestions)
                return null;

            return _questions[CurrentQuestion - 1];
        }

        public QuizAnswer GetCurrentAnswer()
        {
            return _currentAnswer;
        }

        public void SetAnswer(QuizQuestion currentQuestion, string selectedAnswer)
        {
            var answer = new QuizAnswer(currentQuestion, selectedAnswer);
            _currentAnswer = answer;

            Answers.Add(answer);

            IncrementCurrentQuestion();

            if (answer.IsCorrect())
                IncrementScore();
        }

        public int GetScore()
        {
            return base.GetScore();
        }
    }
}
