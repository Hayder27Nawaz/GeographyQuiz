//namespace App.Models
namespace geography_coursework.Models
{
    public class QuizAnswer
    {
        public QuizAnswer(QuizQuestion quizQuestion, string selectedAnswer)
        {
            Question = quizQuestion;
            SelectedAnswer = selectedAnswer;
        }

        public QuizQuestion Question { get; set; }
        public string SelectedAnswer { get; set; } = string.Empty;

        public bool IsCorrect()
            => SelectedAnswer.Equals(Question.Answer);
    }
}
