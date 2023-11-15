using geography_coursework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace geography_coursework.Interfaces
{
    public interface IQuiz
    {
        string Type { get; }
        string Name { get; }
        int CurrentQuestion { get; }
        int TotalQuestions { get; }
        List<QuizAnswer> Answers { get; }
        int TimerCounter { get; }

        bool IsReviewMode();
        bool IsTimerEnabled();
        QuizQuestion GetNextQuestion();
        QuizAnswer GetCurrentAnswer();
        void SetAnswer(QuizQuestion currentQuestion, string selectedAnswer);
        int GetScore();
    }
}
