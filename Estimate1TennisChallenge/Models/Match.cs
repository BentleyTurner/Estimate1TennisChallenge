using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimate1TennisChallenge.Models
{
    public class Match
    {
        public Match() { }
        public Match(string id, Player player1, Player player2, int player1SetWins, int player2SetWins)
        {
            Id = id;
            Player1 = player1;
            Player2 = player2;
            Player1SetWins = player1SetWins;
            Player2SetWins = player2SetWins;

        }
        public String? Id { get; set; }
        public Player? Player1 { get; set; }
        public Player? Player2 { get; set; }

        public int Player1SetWins = 0;
        public int Player2SetWins = 0;
        public int Player1CurrentGamePoints = 0;
        public int Player2CurrentGamePoints = 0;
        public int Player1CurrentGameWins = 0;
        public int Player2CurrentGameWins = 0;

        public void AddPoint(int playerNumber)
        {
            if (playerNumber == 0)
            {
                Player1CurrentGamePoints++;
            }
            else if (playerNumber == 1)
            {
                Player2CurrentGamePoints++;
            }
            if (Player1GameWinCondition())
            {
                Player1CurrentGameWins++;
                Player1.AddWin();
                Player2.AddLoss();
                ResetGameScores();
            }
            else if (Player2GameWinCondition())
            {
                Player2CurrentGameWins++;
                Player1.AddLoss();
                Player2.AddWin();
                ResetGameScores();
            }
            if (Player1CurrentGameWins == 6)
            {
                Player1SetWins++;
                ResetGameWins();
            }
            else if (Player2CurrentGameWins == 6)
            {
                Player2SetWins++;
                ResetGameWins();
            }
        }


        public string GetMatchResult()
        {
            string winner = Player1SetWins > Player2SetWins ? Player1.Name : Player2.Name;
            string loser = winner == Player1.Name ? Player2.Name : Player1.Name;
            string winnerScore = winner == Player1.Name ? Player1SetWins.ToString() : Player2SetWins.ToString();
            string loserScore = winner == Player2.Name ? Player1SetWins.ToString() : Player2SetWins.ToString();

            return $"{winner} defeated {loser}\n{winnerScore} to {loserScore}";
        }

        private bool Player1GameWinCondition()
        {
            return (Player1CurrentGamePoints >= 4 && Player1CurrentGamePoints >= Player2CurrentGamePoints + 2);
        }

        private bool Player2GameWinCondition()
        {
            return (Player2CurrentGamePoints >= 4 && Player2CurrentGamePoints >= Player1CurrentGamePoints + 2);
        }
        private void ResetGameScores()
        {
            Player1CurrentGamePoints = 0;
            Player2CurrentGamePoints = 0;
        }
        private void ResetGameWins()
        {
            Player1CurrentGameWins = 0;
            Player2CurrentGameWins = 0;
        }
    }
}
