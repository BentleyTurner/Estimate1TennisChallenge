using Estimate1TennisChallenge;

namespace Estimate1TennisChallengeTest
{
    public class UtilsTest
    {
        [Fact]
        public void ShouldSuccessfullyReturnWhenMatchIdDoesMatch()
        {
            string expectedReturn = "Barry defeated Adam\n3 to 2";
            var actualReturn = Utils.PrintMatchResult("01", Fixtures.testMatchList);

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void ShouldDisplayErrorWhenMatchIdDoesntMatch()
        {
            string expectedReturn = "Couldnt find a match with an ID of: 08";
            var actualReturn = Utils.PrintMatchResult("08", Fixtures.testMatchList);

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void ShouldSuccessfullyReturnWhenPlayerNameDoesMatch()
        {
            string expectedReturn = "30 15";
            var actualReturn = Utils.PrintPlayerGames("Garry", Fixtures.testPlayerList);

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void ShouldDisplayErrorWhenPlayerNameDoesntMatch()
        {
            string expectedReturn = "Couldnt find a player with the name: Barry";
            var actualReturn = Utils.PrintPlayerGames("Barry", Fixtures.testPlayerList);

            Assert.Equal(expectedReturn, actualReturn);
        }
    }
}
