using TwoKatas;
using TechTalk.SpecFlow;
using Xunit;

namespace BDDTests.StepDefinitions
{
    [Binding]
    public sealed class BowlingGameStepDefinitions
    {
        BowlingGame bowlingGame = new BowlingGame();
        int actualScore = 0;

        [Given("the player knocks down 10 pins with 1 roll")]
        public void GivenThePlayerKnocksDown10PinsWith1Roll()
        {
            bowlingGame.RecordRoll(10);
        }

        [When("the player rolls the next 2 balls")]
        public void WhenThePlayerRollsTheNext2Balls()
        {
            bowlingGame.RecordRoll(6);
            bowlingGame.RecordRoll(3);
        }

        [Then("the amount of pins knocked down by those 2 balls is added as bonus")]
        public void ThenTheAmountOfPinsKnockedDownByThose2BallsIsAddedAsBonus()
        {
            actualScore = bowlingGame.CalculateScore();
            Assert.Equal(28, actualScore);
        }

        [Given("the player knocks down 10 pins with 2 rolls")]
        public void GivenThePlayerKnocksDown10PinsWith2Rolls()
        {
            bowlingGame.RecordRoll(5);
            bowlingGame.RecordRoll(5);
        }

        [When("the player rolls the next ball")]
        public void WhenThePlayerRollsTheNextBall()
        {
            bowlingGame.RecordRoll(4);
        }

        [Then("the amount of pins knocked down by that ball is added as bonus")]
        public void ThenTheAmountOfPinsKnockedDownByThatBallIsAddedAsBonus()
        {
            actualScore = bowlingGame.CalculateScore();
            Assert.Equal(18, actualScore);
        }
    }
}