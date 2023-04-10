using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimate1TennisChallenge.Models
{
    public class Player
    {
        public string Name { get; }
        public int GamesLost { get; private set; }
        public int GamesWon { get; private set; }

        public Player(string name)
        {
            Name = name;
            GamesLost = 0;
            GamesWon = 0;
        }

        public Player(string name, int gamesLost, int gamesWon) : this(name)
        {
            GamesLost = gamesLost;
            GamesWon = gamesWon;
        }

        public void AddWin() { GamesWon++; }
        public void AddLoss() { GamesLost++; }
    }
}
