using Estimate1TennisChallenge.Models;

namespace Estimate1TennisChallenge
{
    public class Utils
    {
        public static bool playerExist(string playerName, List<Player> players)
        {
            return players.Any(x => x.Name == playerName);
        }

        public static Player getPlayer(string playerName, List<Player> players)
        {
            return players.Find(x => x.Name == playerName);
        }

        public static Models.Match getMatch(string matchId, List<Models.Match> matches)
        {
            return matches.Find(x => x.Id == matchId);
        }

        public static String PrintPlayerGames(string playerName, List<Player> players)
        {
            Player player = getPlayer(playerName, players);
            if (player == null) { return $"Couldnt find a player with the name: {playerName}"; }
            else { return $"{player.GamesWon} {player.GamesLost}"; }

        }

        public static String PrintMatchResult(String matchId, List<Models.Match> matches)
        {
            Models.Match matchToPrint = getMatch(matchId, matches);
            if (matchToPrint == null) { return $"Couldnt find a match with an ID of: {matchId}"; }
            else { return matchToPrint.GetMatchResult(); }
        }

    }
}
