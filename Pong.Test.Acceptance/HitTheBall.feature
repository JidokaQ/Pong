Feature:  Hit The Ball
	In order to play the Pong game
	As a player
	I want my paddle to return the ball

Scenario: 45 degree hit
	Given game server is started
	And player is participating in a game
	And ball is in motion with a speed and a direction
	And paddle <1> touches the ball
	When the ball hits with <45> degree angle
	Then the ball should be bounced at 135 degree

Scenario: 50 degree hit
	Given game server is started
	And player is participating in a game
	And ball is in motion with a speed and a direction
	And paddle <1> touches the ball
	When the ball hits with <50> degree angle
	Then the ball should be bounced at <130> degree