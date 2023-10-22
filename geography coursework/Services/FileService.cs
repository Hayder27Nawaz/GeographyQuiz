using geography_coursework.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace geography_coursework.Services
{
    public class FileService
    {
        public List<QuizQuestion> GetQuestions() 
        {
            //  Load file
            string filePath = "QuizQuestions.cs";
            List<string[]> csvData = LoadCSV(filePath);

            foreach (string[] row in csvData)
            {
                foreach (string value in row)
                {
                    Console.Write(value + "\t");
                }
                Console.WriteLine();
            }
            return new List<QuizQuestion>();
        }

        public static List<string[]> LoadCSV(string filePath)
        {
            List<string[]> data = new List<string[]>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        data.Add(values);
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
