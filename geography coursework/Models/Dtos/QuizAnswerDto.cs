using System;

namespace geography_coursework.Models.Dtos
{
    public class QuizAnswerDto
    {
        public int Id;
        public int QuizId;
        public string Category;
        public string Question;
        public string OptionA;
        public string OptionB;
        public string OptionC;
        public string OptionD;
        public string Answer;
        public string SelectedAnswer;
        public int DifficultyLevel;
        public bool IsCorrect;
        public DateTime Created;
    }
}
