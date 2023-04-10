using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimate1TennisChallenge.Models
{
    public class Set
    {
        public string Winner { get; }
        public string Loser { get; }

        public Set(string player1Name, string player2Name)
        {
            Winner = player1Name;
            Loser = player2Name;
        }
    }
}
