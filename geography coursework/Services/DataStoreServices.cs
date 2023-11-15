using System.Data.SQLite;
using System.Collections.Generic;
using geography_coursework.Models;
using System.IO;
using System.Linq;
using System.Text;
using geography_coursework.Models.Dtos;
using System;
using geography_coursework.Interfaces;

namespace geography_coursework.Services
{
    public class DataStoreService
    {
        private static string ConnectionString = "Data Source=GeographtQuiz.db;Version=3;New=True;Compress=True;Pooling=false;";
        private const string QuizTableName = "Quiz";
        private const string QuizAnswers = "QuizAnswers";

        public DataStoreService()
        {
            if (!TablesExist())
                CreateTables();

            //SQLiteDatabase.setLockingEnabled(false);
        }

        private static bool TablesExist()
        {
            var query = $"SELECT name FROM sqlite_master  WHERE type = 'table' AND name = '{QuizTableName}';";

            using (var conn = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    var reader = command.ExecuteReader();

                    if (!reader.HasRows)
                        return false;

                    while (reader.Read())
                    {
                        var tableName = reader[0].ToString();
                        return QuizTableName.Equals(tableName);
                    }

                    return false;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    command.Dispose();
                }
            }
        }

        private static void CreateTables()
        {
            var query = $"CREATE TABLE {QuizTableName} (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(50), Type VARCHAR(10), Score INTEGER, Created DATETIME); " +
                        $"CREATE TABLE {QuizAnswers} (Id INTEGER PRIMARY KEY AUTOINCREMENT, QuizId INTEGER, Category VARCHAR(50), Question VARCHAR(255), OptionA VARCHAR(50), OptionB VARCHAR(50), OptionC VARCHAR(50), OptionD VARCHAR(50), Answer VARCHAR(50), SelectedAnswer VARCHAR(50), DifficultyLevel INT, IsCorrect BIT, Created DATETIME);";

            using (var conn = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    command.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    command.Dispose();
                }
            }
        }

        public IQuiz GetQuiz(int quizId)
        {
            var quiz = GetQuizDto(quizId);
            var answers = GetQuizAnswers(quizId);

            return new ReviewModeQuiz(quiz, answers);
        }

        public void Save(IQuiz quiz)
        {
            var quizId = SaveQuiz(quiz);
            SaveQuizAnswers(quiz, quizId);
        }

        private QuizDto GetQuizDto(int quizId)
        {
            var quiz = new QuizDto();

            var query = $"SELECT Id, Name, Type, Score, Created FROM {QuizTableName} WHERE Id = {quizId}";

            using (var conn = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    var reader = command.ExecuteReader();

                    if (!reader.HasRows)
                        throw new Exception($"Unable to find quiz matching {quizId}");

                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var type = reader.GetString(2);
                        var score = reader.GetInt32(3);
                        var created = reader.GetDateTime(4);

                        quiz = new QuizDto
                        {
                            Id = id,
                            Name = name,
                            Type = type,
                            Score = score,
                            Created = created,
                        };
                    }

                    return quiz;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    command.Dispose();
                }
            }
        }

        private List<QuizAnswerDto> GetQuizAnswers(int quizId)
        {
            var answers = new List<QuizAnswerDto>();

            var query = $"SELECT Id, Category, Question, OptionA, OptionB, OptionC, OptionD, Answer, SelectedAnswer, DifficultyLevel FROM {QuizAnswers} WHERE QuizId = {quizId}";

            using (var conn = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    var reader = command.ExecuteReader();

                    if (!reader.HasRows)
                        throw new Exception($"Unable to find quiz matching {quizId}");

                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var category = reader.GetString(1);
                        var question = reader.GetString(2);
                        var optionA = reader.GetString(3);
                        var optionB = reader.GetString(4);
                        var optionC = reader.GetString(5);
                        var optionD = reader.GetString(6);
                        var answer = reader.GetString(7);
                        var selectedAnswer = reader.GetString(8);
                        var difficultyLevel = reader.GetInt32(9);

                        answers.Add(new QuizAnswerDto
                        {
                            Category = category,
                            Question = question,
                            OptionA = optionA,
                            OptionB = optionB,
                            OptionC = optionC,
                            OptionD = optionD,
                            Answer = answer,
                            SelectedAnswer = selectedAnswer,
                            DifficultyLevel = difficultyLevel
                        });
                    }

                    return answers;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    command.Dispose();
                }
            }
        }

        private int SaveQuiz(IQuiz quiz)
        {
            var quizId = 0;

            var query = $"INSERT INTO {QuizTableName}(Id, Name, Type, Score, Created) VALUES(@Id, @Name, @Type, @Score, @Created); " +
                        $"SELECT last_insert_rowid() FROM {QuizTableName} LIMIT 1";

            using (var conn = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    command.Parameters.AddWithValue("@Id", null);
                    command.Parameters.AddWithValue("@Name", quiz.Name);
                    command.Parameters.AddWithValue("@Type", quiz.Type);
                    command.Parameters.AddWithValue("@Score", quiz.GetScore());
                    command.Parameters.AddWithValue("@Created", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    var reader = command.ExecuteReader();

                    if (!reader.HasRows)
                        throw new Exception("Failed to insert quiz record.");

                    while (reader.Read())
                    {
                        quizId = reader.GetInt32(0);
                    }
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    command.Dispose();
                }
            }
            return quizId;
        }

        private void SaveQuizAnswers(IQuiz quiz, int quizId)
        {
            var query = $"INSERT INTO {QuizAnswers}(Id, QuizId, Category, Question, OptionA, OptionB, OptionC, OptionD, Answer, SelectedAnswer, DifficultyLevel, IsCorrect, Created) " +
                        $"VALUES(@Id, @QuizId, @Category, @Question, @OptionA, @OptionB, @OptionC, @OptionD, @Answer, @SelectedAnswer, @DifficultyLevel, @IsCorrect, @Created);";

            using (var conn = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    foreach (var answer in quiz.Answers)
                    {
                        command.Parameters.AddWithValue("@Id", null);
                        command.Parameters.AddWithValue("@QuizId", quizId);
                        command.Parameters.AddWithValue("@Category", answer.Question.Category);
                        command.Parameters.AddWithValue("@Question", answer.Question.Question);
                        command.Parameters.AddWithValue("@OptionA", answer.Question.OptionA);
                        command.Parameters.AddWithValue("@OptionB", answer.Question.OptionB);
                        command.Parameters.AddWithValue("@OptionC", answer.Question.OptionC);
                        command.Parameters.AddWithValue("@OptionD", answer.Question.OptionD);
                        command.Parameters.AddWithValue("@Answer", answer.Question.Answer);
                        command.Parameters.AddWithValue("@SelectedAnswer", answer.SelectedAnswer);
                        command.Parameters.AddWithValue("@DifficultyLevel", answer.Question.DifficultyLevel);
                        command.Parameters.AddWithValue("@IsCorrect", answer.IsCorrect() ? 1 : 0);
                        command.Parameters.AddWithValue("@Created", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    command.Dispose();
                }
            }
        }

        public List<Highscore> GetHighscores(string sort, int limit)
        {
            var highscores = new List<Highscore>();

            var query = $"SELECT Id, Name, Type, Score, Created FROM {QuizTableName} ORDER BY Score {sort} LIMIT {limit}";

            using (var conn = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    var reader = command.ExecuteReader();

                    if (!reader.HasRows)
                        return highscores;

                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var type = reader.GetString(2);
                        var score = reader.GetInt32(3);
                        var created = reader.GetDateTime(4);

                        highscores.Add(new Highscore(id, name, type, score, created));
                    }

                    return highscores;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    command.Dispose();
                }
            }
        }

        public List<ChartDto> GetChartDetails()
        {
            var results = new List<ChartDto>();

            var query = $"SELECT " +
                        $"Category, " +
                        $"SUM(CASE WHEN IsCorrect THEN 1 ELSE 0 END) AS CorrectAnswers, " +
                        $"SUM(CASE WHEN NOT IsCorrect THEN 1 ELSE 0 END) AS IncorrectAnswers " +
                        $"FROM {QuizAnswers} " +
                        $"GROUP BY Category";

            using (var conn = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    var reader = command.ExecuteReader();

                    if (!reader.HasRows)
                        throw new Exception("Unable to load chart details");

                    while (reader.Read())
                    {
                        var league = reader.GetString(0);
                        var correct = reader.GetInt32(1);
                        var incorrect = reader.GetInt32(2);

                        results.Add(new ChartDto
                        {
                            League = league,
                            Correct = correct,
                            Incorrect = incorrect
                        });
                    }

                    return results;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                    command.Dispose();
                }
            }
        }
    }
}
