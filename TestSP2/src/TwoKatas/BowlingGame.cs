using System;

namespace TwoKatas
{
    public class BowlingGame
    {
        private int[] rollsArray = new int[21];
        private int currentRollIndex = 0;

        public BowlingGame()
        {

        }

        public void RecordRoll(int pins)
        {
            rollsArray[currentRollIndex++] = pins;
        }

        public int CalculateScore()
        {
            int totalScore = 0;
            int currentFrameIndex = 0;

            for (int frameNumber = 0; frameNumber < 10; frameNumber++)
            {
                if (IsStrike(currentFrameIndex))
                {
                    totalScore += 10 + CalculateStrikeBonus(currentFrameIndex);
                    currentFrameIndex++;
                }
                else if (IsSpare(currentFrameIndex))
                {
                    totalScore += 10 + CalculateSpareBonus(currentFrameIndex);
                    currentFrameIndex += 2;
                }
                else
                {
                    totalScore += CalculateFrameScore(currentFrameIndex);
                    currentFrameIndex += 2;
                }
            }
            return totalScore;
        }

        private int CalculateFrameScore(int frameIndex)
        {
            return rollsArray[frameIndex] + rollsArray[frameIndex + 1];
        }

        private int CalculateSpareBonus(int frameIndex)
        {
            return rollsArray[frameIndex + 2];
        }

        private int CalculateStrikeBonus(int frameIndex)
        {
            return rollsArray[frameIndex + 1] + rollsArray[frameIndex + 2];
        }

        private bool IsSpare(int frameIndex)
        {
            return CalculateFrameScore(frameIndex) == 10;
        }

        private bool IsStrike(int frameIndex)
        {
            return rollsArray[frameIndex] == 10;
        }
    }
}