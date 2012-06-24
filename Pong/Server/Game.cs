using System;
using System.Collections;
using System.Collections.Generic;

namespace Pong.Server
{
	public class Game
	{
		
		private List<Player> player;
		private int numberOfParticipants;

		public List<Player> Player {
			get {
				return this.player;
			}
			set {
				player = value;
			}
		}
		
		public Game (int numberOfParticipants)
		{
			Player = new List<Player>();
			this.numberOfParticipants = numberOfParticipants;
		}
		
		public Boolean RegisterPlayer(Player player)
		{
			if (Player.Count + 1 > this.numberOfParticipants) {
				return false;
			}
			Player.Add(player);
			return true;					
		}
	}
}

