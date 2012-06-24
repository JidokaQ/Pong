using System;

namespace Pong.Server
{
	public class GameServer
	{
		public GameServer ()
		{
		}
		
		private Boolean isStarted = false;
		
		
		public Boolean IsStarted {
			get {
				return this.isStarted;
			}
			set {
				isStarted = value;
			}
		}
	}
}

