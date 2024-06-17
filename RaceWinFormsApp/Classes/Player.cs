using System;

namespace RaceWinFormsApp
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int CoinsScore { get; set; }
        public DateTime GameDate { get; set; }

        public Player() => Name = "NoName";
        public Player(string Name) => this.Name = Name;
        public void ResetResults()
        {
            Score = 0;
            CoinsScore = 0;
        }
    }
}
