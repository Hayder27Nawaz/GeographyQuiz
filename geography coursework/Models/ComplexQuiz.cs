using App.Models;
using geography_coursework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace geography_coursework.Models
{
    public class ComplexQuiz : QuizBase, IQuiz
    {
        private const int TotalNumberOfQuestions = 10;
        private readonly List<QuizQuestion> _questions;

        private decimal DifficultlyRating = 10m;
        private QuizAnswer _currentAnswer;

        public ComplexQuiz(string name, List<QuizQuestion> questions)
        {
            Name = name;
            TotalQuestions = TotalNumberOfQuestions;

            _questions = questions;
        }

        public string Type => "Complex";

        public int TimerCounter => -1;

        List<QuizAnswer> IQuiz.Answers => throw new System.NotImplementedException();

        public bool IsReviewMode()
        {
            return false;
        }

        public bool IsTimerEnabled()
        {
            return false;
        }

        public QuizQuestion GetNextQuestion()
        {
            if (CurrentQuestion > TotalNumberOfQuestions)
                return null;

            var random = new Random(Guid.NewGuid().GetHashCode());

            Shuffle(_questions);

            var shuffledQuestions = _questions
                .Where(q => q.DifficultyLevel == CalculateDifficultyRating())
                .OrderBy(q => q.DifficultyLevel)
                .ToList();

            var randomNumber = random.Next(0, shuffledQuestions.Count);

            return shuffledQuestions
                .ElementAt(randomNumber);
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
            {
                IncrementScore();
                IncrementDifficultly();
            }
            else
                ResetDifficultly();
        }

        public int GetScore()
        {
            return base.GetScore();
        }

        private int CalculateDifficultyRating()
        {
            return DifficultlyRating switch
            {
                > 30m => 30,
                > 20m => 20,
                _ => 10
            };
        }

        private static void Shuffle<T>(List<T> list)
        {
            var rng = new Random();
            var n = list.Count;

            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void IncrementDifficultly()
        {
            DifficultlyRating *= 1.2m;
        }

        private void ResetDifficultly()
        {
            DifficultlyRating = 10m;
        }
    }
}
