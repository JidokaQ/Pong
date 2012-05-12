Feature:  Hit The Ball hard
	In order to play the Pong game
	As a player
	I want my paddle to return the ball

Scenario: 45 degree hit
	Given paddle 1 touches the ball
	When the ball hits with 45 degree angle
	Then the ball should be bounced at 135 degree

Scenario: 50 degree hit
	Given paddle 1 touches the ball
	When the ball hits with 50 degree angle
	Then the ball should be bounced at 130 degree