using Estimate1TennisChallenge.Models;

namespace Estimate1TennisChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Read input from text file
            string[] lines = File.ReadAllLines("C:\\Git\\TennisCalculator\\TennisCalculator\\InputFile.txt");
            List<Player> Players = new List<Player>();

            // Parse input into list of match results
            List<Models.Match> Matches = ParseInput(lines, Players);

            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine(" WELCOME TO TENNIS CALCULATOR ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Available commands: ");
            Console.WriteLine("Games Player <Player Name> ");
            Console.WriteLine("Score Match <Match Id Number> ");
            Console.WriteLine("Type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Exiting...");
                        break;
                    }
                    else if (input.StartsWith("Games Player", StringComparison.OrdinalIgnoreCase))
                    {
                        string[] command = input.Split("Player ", StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine(Utils.PrintPlayerGames(command[1], Players));
                    }
                    else if (input.StartsWith("Score Match", StringComparison.OrdinalIgnoreCase))
                    {
                        string[] command = input.Split("Match ", StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine(Utils.PrintMatchResult(command[1], Matches));
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry Couldnt find a match or player with the input provided");
                }

            }
        }

        public static List<Models.Match> ParseInput(string[] input, List<Player> players)
        {
            List<Models.Match> Matches = new List<Models.Match>();
            Models.Match currentMatch = new Match();

            foreach (string line in input)
            {
                if (line.StartsWith("Match: "))
                {
                    currentMatch = new Models.Match();
                    currentMatch.Id = line.Substring(7);
                    Matches.Add(currentMatch);
                }
                else if (line.Contains(" vs "))
                {
                    string[] currentPlayers = line.Split(" vs ");

                    String player1 = currentPlayers[0].Trim();
                    String player2 = currentPlayers[1].Trim();

                    if (Utils.playerExist(player1, players))
                    {
                        currentMatch.Player1 = Utils.getPlayer(player1, players);
                    }
                    else
                    {
                        players.Add(new Player(player1));
                        currentMatch.Player1 = Utils.getPlayer(player1, players);
                    }

                    if (Utils.playerExist(player2, players))
                    {
                        currentMatch.Player2 = Utils.getPlayer(player2, players);
                    }
                    else
                    {
                        players.Add(new Player(player2));
                        currentMatch.Player2 = Utils.getPlayer(player2, players);
                    }

                }
                else if (line != "")
                {
                    int playerNumber = int.Parse(line);
                    currentMatch.AddPoint(playerNumber);
                }
            }

            return Matches;

        }


    }
}