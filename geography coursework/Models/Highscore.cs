using System;

namespace geography_coursework.Models
{
    public class Highscore
    {
        public int Id { get; set; }
        public string Username { get; }
        public string Type { get; }
        public int Score { get; }
        public System.DateTime Created { get; }

        public Highscore(int id, string name, string type, int score, DateTime created)
        {
            Id = id;
            Username = name;
            Type = type;
            Score = score;
            Created = created;
        }
    }
}
