using System;
using System.Collections.Generic;
using System.Text;

namespace geography_coursework.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }
        public int DifficultyLevel { get; set; }

        public static QuizQuestion
    From(string csvLine)
        {
            var columns = csvLine.Split(",");

            return new QuizQuestion
            {
                Question = columns[0],
                OptionA = columns[1],
                OptionB = columns[2],
                OptionC = columns[3],
                OptionD = columns[4],
                Answer = columns[5],
                DifficultyLevel = int.Parse(columns[6])
            };
        }

    }
}
