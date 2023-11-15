using geography_coursework.Interfaces;
using geography_coursework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Models
{
    public class SimpleQuiz : QuizBase, IQuiz
    {
        private const int TotalNumberOfQuestions = 5;

        private Stack<QuizQuestion> _questionQueue = new();
        private QuizAnswer _currentAnswer;

        public SimpleQuiz(string name, List<QuizQuestion> questions)
        {
            Name = name;
            TotalQuestions = TotalNumberOfQuestions;

            SelectRandomQuestions(questions);
        }

        private void SelectRandomQuestions(List<QuizQuestion> questions)
        {
            var randomQuestions = new List<QuizQuestion>();

            var random = new Random(Guid.NewGuid().GetHashCode());

            for (var count = 0; count < TotalNumberOfQuestions; count++)
            {

                var randomNumber = random.Next(0, questions.Count);

                randomQuestions.Add(questions.ElementAt(randomNumber));
            }

            foreach (var question in randomQuestions.OrderByDescending(q => q.DifficultyLevel))
            {
                _questionQueue.Push(question);
            }
        }

        public bool IsReviewMode()
        {
            return false;
        }

        public bool IsTimerEnabled()
        {
            return false;
        }

        public string Type => "Simple";

        public int TimerCounter => -1;

        public QuizQuestion GetNextQuestion()
        {
            if (_questionQueue.Count == 0)
                return null;

            return _questionQueue.Pop();
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
