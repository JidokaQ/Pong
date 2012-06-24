using System;

namespace Pong
{
	public class PongGame
	{
		public PongGame ()
		{
			
			
			
		}
				
		public int IncommingAngle { get; set; }

        public bool CheckPaddleBallCollision(int paddle)
        {
            	if (paddle == 1)
                return true;
            else
                return false;
        }

        public int GetBouncedAngle()
        {
            return 180 - IncommingAngle;
        }
	}
}

