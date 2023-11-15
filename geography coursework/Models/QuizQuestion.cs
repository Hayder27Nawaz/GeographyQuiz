namespace geography_coursework.Models
{
    public class QuizQuestion
    {
        public string Category { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }
        public int DifficultyLevel { get; set; }

        public static QuizQuestion From(string csvLine)
        {
            var columns = csvLine.Split(",");

            return new QuizQuestion
            {
                Category = columns[0],
                Question = columns[1],
                OptionA = columns[2],
                OptionB = columns[3],
                OptionC = columns[4],
                OptionD = columns[5],
                Answer = columns[6],
                DifficultyLevel = int.Parse(columns[7])
            };
        }
    }
}
