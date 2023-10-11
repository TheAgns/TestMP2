using TwoKatas;
using Xunit;

namespace BowlingGameTests
{
    public class BowlingGameTest
    {
        BowlingGame bowlingGame = new BowlingGame();

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                bowlingGame.RecordRoll(pins);
            }
        }

        private void RollSpare()
        {
            bowlingGame.RecordRoll(5);
            bowlingGame.RecordRoll(5);
        }

        private void RollStrike()
        {
            bowlingGame.RecordRoll(10);
        }

        [Fact]
        public void TestGutterGame()
        {
            RollMany(20, 0);
            Assert.Equal(0, bowlingGame.CalculateScore());
        }

        [Fact]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            Assert.Equal(20, bowlingGame.CalculateScore());
        }

        [Fact]
        public void TestOneSpare()
        {
            RollSpare();
            bowlingGame.RecordRoll(3);
            RollMany(17, 0);
            Assert.Equal(16, bowlingGame.CalculateScore());
        }

        [Fact]
        public void TestOneStrike()
        {
            RollStrike();
            bowlingGame.RecordRoll(3);
            bowlingGame.RecordRoll(4);
            RollMany(16, 0);
            Assert.Equal(24, bowlingGame.CalculateScore());
        }

        [Fact]
        public void TestPerfectGame()
        {
            RollMany(12, 10);
            Assert.Equal(300, bowlingGame.CalculateScore());
        }
    }
}