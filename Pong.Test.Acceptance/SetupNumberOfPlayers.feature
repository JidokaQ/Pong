Feature: Setup number of players
	In order to play multiplayer game
	As a main player
	I want to be able to choose in what mode to play
	
@mytag
Scenario: Register a new game
	Given there is a game in init mode
	And you are not in another game
	When user choose 2 player
	Then 2 paddles should be in the game



