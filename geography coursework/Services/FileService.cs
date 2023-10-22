using geography_coursework.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace geography_coursework.Services
{
    public class FileService
    {
        public List<QuizQuestion> GetQuestions() 
        {
            List<QuizQuestion> quizQuestions = new List<QuizQuestion>();

            //  Load file
            string filePath = "quiz_questions/geography_questions.csv";
            List<string> csvData = LoadCSV(filePath);

            foreach (string row in csvData.Skip(1))
            {
                quizQuestions.Add(QuizQuestion.From(row));
            }

            return quizQuestions;
        }

        private static List<string> LoadCSV(string filePath)
        {
            List<string> data = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        data.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return data;
        }
    }
}
