using System.Collections.Generic;
using System.Linq;
using geography_coursework.Interfaces;
using geography_coursework.Models;
using geography_coursework.Models.Dtos;


namespace geography_coursework.Models
{
    public class ReviewModeQuiz : QuizBase, IQuiz
    {
        private Stack<QuizAnswer> _answerQueue = new();
        private QuizAnswer _currentAnswer;

        public ReviewModeQuiz(IQuiz quiz)
        {
            Name = quiz.Name;
            TotalQuestions = quiz.TotalQuestions;
            Answers = quiz.Answers;

            if(!quiz.IsReviewMode())
                Answers.Reverse();

            SetupQueue();
        }

        public ReviewModeQuiz(QuizDto quiz, List<QuizAnswerDto> answers)
        {
            Name = quiz.Name;
            TotalQuestions = answers.Count;

            Answers = answers
                .Select(dto => new QuizAnswer
                (
                    new QuizQuestion
                    {
                        Category = dto.Category,
                        Question = dto.Question,
                        OptionA = dto.OptionA,
                        OptionB = dto.OptionB,
                        OptionC = dto.OptionC,
                        OptionD = dto.OptionD,
                        Answer = dto.Answer,
                        DifficultyLevel = dto.DifficultyLevel,
                    },
                    dto.SelectedAnswer
                ))
                .ToList();

            SetupQueue();
        }

        private void SetupQueue()
        {
            foreach (var answer in Answers)
            {
                _answerQueue.Push(answer);
            }
        }

        public bool IsReviewMode()
        {
            return true;
        }
        public bool IsTimerEnabled()
        {
            return false;
        }

        public string Type => "Review";

        public int TimerCounter => -1;

        public QuizQuestion GetNextQuestion()
        {
            if (_answerQueue.Count == 0)
                return null;

            var answer = _answerQueue.Pop();
            _currentAnswer = answer;

            return answer.Question;
        }

        public QuizAnswer GetCurrentAnswer()
        {
            return _currentAnswer;
        }

        public void SetAnswer(QuizQuestion currentQuestion, string selectedAnswer)
        {
            CurrentQuestion += 1;
        }

        public new int GetScore()
        {
            return Answers.Count(a => a.IsCorrect()) * PointsPerQuestion;
        }
    }
}
