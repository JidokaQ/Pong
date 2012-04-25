using System;

using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Pong.Test.Acceptance
{
	[Binding]
    public class HitTheBallSteps
    {
        private Pong.PongGame pongGame;

        [Given(@"paddle (.*) touches the ball")]
        public void GivenPaddleXTouchesTheBall(int paddle)
        {
            pongGame = new PongGame();
            Assert.AreEqual(true, pongGame.CheckPaddleBallCollision(paddle));
   
        }

        [Then(@"the ball should be bounced at (.*) degree")]
        public void ThenTheBallShouldBeBouncedAt135Degree(int angle)
        {
            Assert.AreEqual(angle, pongGame.GetBouncedAngle());
        }

        [When(@"the ball hits with (.*) degree angle")]
        public void WhenTheBallHitsPaddle1With45Degree(int angle)
        {
            pongGame.IncommingAngle = angle;
            Assert.AreEqual(angle, pongGame.IncommingAngle);
        }
    }
}
		
