Feature: Setup number of players
	In order to play multiplayer game
	As a game admin
	I want to be able to setup number of players allowed in a game server
	

Scenario: Setup number of allowed players
	Given game server is started
	When game admin selects 1000 players
	Then 1000 players should be allowed entering a game



