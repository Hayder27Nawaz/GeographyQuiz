using App.Models;
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
        private const string FilePath = "Data/questions.csv";

        public List<QuizQuestion> GetQuestions()
        {
            var csvData = LoadCsv(FilePath);

            return csvData
                .Skip(1) // Skip header row
                .Select(QuizQuestion.From)
                .ToList();
        }

        private static IEnumerable<string> LoadCsv(string filePath)
        {
            var data = new List<string>();

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        // ignore empty lines
                        if (line != null)
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
