using Estimate1TennisChallenge.Models;

namespace Estimate1TennisChallengeTest
{
    public static class Fixtures
    {
        public static List<Match> testMatchList =
            new List<Match>() { new Match("01", new Player("Adam"), new Player("Barry"), 2, 3),
                new Match("02", new Player("Garry"), new Player("Barry"), 1, 3),
                new Match("03", new Player("Fred"), new Player("Barry"), 3, 1),
                new Match("04", new Player("Adam"), new Player("Barry"), 0, 3),
            };

        public static List<Player> testPlayerList = new List<Player>() { new Player("Garry", 15, 30), };

        public static Match testMatchwithPlayer1Winner = new Match("01", new Player("Garry"), new Player("Barry"), 3, 2);

        public static Match testMatchwithPlayer2Winner = new Match("01", new Player("Garry"), new Player("Barry"), 2, 3);

        public static Match testMatchatAtDraw = new Match("01", new Player("Garry"), new Player("Barry"), 2, 2);
    }
}
