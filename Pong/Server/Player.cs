using System;

namespace Pong.Server
{
	public class Player
	{
		private int id;
		private String name;

		public int Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public String Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}		
		public Player ()
		{

		}
	}
}

