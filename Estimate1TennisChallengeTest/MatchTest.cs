using Estimate1TennisChallenge;

namespace Estimate1TennisChallengeTest
{
    public class MatchTest
    {
        [Fact]
        public void ShouldDisplayPlayer1WinsIfPlayer1has3SetWins()
        {
            string expectedReturn = "Garry defeated Barry\n3 to 2";
            var testMatch = Fixtures.testMatchwithPlayer1Winner;
            string actualReturn = testMatch.GetMatchResult();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void ShouldDisplayPlayer2WinsIfPlayer2has3SetWins()
        {
            string expectedReturn = "Barry defeated Garry\n3 to 2";
            var testMatch = Fixtures.testMatchwithPlayer2Winner;

            string actualReturn = testMatch.GetMatchResult();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void ShouldDisplayPlayer1WinsIfAddPointWhenAtMatchPoint()
        {
            string expectedReturn = "Garry defeated Barry\n3 to 2";
            var testMatch = Fixtures.testMatchatAtDraw;

            testMatch.Player1CurrentGameWins = 5;
            testMatch.Player1CurrentGamePoints = 3;
            testMatch.AddPoint(0);


            string actualReturn = testMatch.GetMatchResult();

            Assert.Equal(expectedReturn, actualReturn);
        }
    }
}
