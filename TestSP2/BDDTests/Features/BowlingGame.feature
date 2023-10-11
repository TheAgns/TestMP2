Feature: BowlingGame

@mytag
Scenario: Strike
	Given the player knocks down 10 pins with 1 roll
	When the player rolls the next 2 balls
	Then the amount of pins knocked down by those 2 balls is added as bonus

@mytag
Scenario: Spare
	Given the player knocks down 10 pins with 2 rolls 
	When the player rolls the next ball
	Then the amount of pins knocked down by that ball is added as bonus
