Feature: BowlingGame

@mytag
Scenario: a Strike
	Given the player is able to get down 10 pins in 1 cast
	When the player casts the next 2 balls
	Then the amount of pins knocked down by those 2 balls is added as bonus

@mytag
Scenario: a Spare
	Given the player knocks down 10 pins with 2 casts 
	When the player casts the next ball
	Then the amount of pins knocked down by that ball is added as bonus
