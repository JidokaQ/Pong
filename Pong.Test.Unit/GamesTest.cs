using System;
using Pong;
using Pong.Server;
using NUnit.Framework;

namespace Pong.Test.Unit
{
	[TestFixture]
	public class GamesTest
	{
		[Test]
		public void RegisterPlayerTest()
		{
			// To test
			int numberOfParticipants = 2;
		   	Game game = new Game(numberOfParticipants);
			
		   	Player player = new Player();
			player.Id = 1;
			player.Name = "Bertil";
			
		   	Boolean playerAded = game.RegisterPlayer(player);
		   
		   	Assert.AreEqual(1, game.Player.Count);
			Assert.AreEqual(true, playerAded);

			Player player2 = new Player();
			player2.Id = 2;
			player.Name = "Reza";

			playerAded = game.RegisterPlayer(player2);
			
			Assert.AreEqual(2, game.Player.Count);
			Assert.AreEqual(true, playerAded);
			
			Player player3 = new Player();
			player3.Id = 3;
			player.Name = "Johan";

			playerAded = game.RegisterPlayer(player3);
			
			Assert.AreEqual(2, game.Player.Count);
			Assert.AreEqual(false, playerAded);

		}
		
	}
}

