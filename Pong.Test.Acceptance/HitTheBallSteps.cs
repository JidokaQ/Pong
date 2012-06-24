using System;
using Pong.Server;
using TechTalk.SpecFlow;

namespace Pong.Test.Acceptance
{
	[Binding]
    public class HitTheBallSteps
	{
		
		Ball ball;
		Game game;
		Player player;
		
      	[Given(@"player is participating in a game")]
        public void GivenPlayerIsParticipatingInAGame()
        {
            game = new Game();
			player = new Player();
			player.Name = "Bertil";
			player.Id = 1;
			
			game.RegisterPlayer(player);
        }
		
		[Given(@"ball is in motion with a speed and a direction")]
        public void GivenBallIsInMotionWithASpeedAndADirection()
        {
            ScenarioContext.Current.Pending();
        }
		
		[Given(@"paddle <1> touches the ball")]
        public void GivenPaddle1TouchesTheBall()
        {
            ScenarioContext.Current.Pending();
        }
		
		[When(@"the ball hits with <45> degree angle")]
        public void WhenTheBallHitsWith45DegreeAngle()
        {
            ScenarioContext.Current.Pending();
        }
		
		[Then(@"the ball should be bounced at 135 degree")]
        public void ThenTheBallShouldBeBouncedAt135Degree()
        {
            ScenarioContext.Current.Pending();
        }
		
		[When(@"the ball hits with <50> degree angle")]
        public void WhenTheBallHitsWith50DegreeAngle()
        {
            ScenarioContext.Current.Pending();
        }
		
		[Then(@"the ball should be bounced at <130> degree")]
        public void ThenTheBallShouldBeBouncedAt130Degree()
        {
            ScenarioContext.Current.Pending();
        }
	}
}
		
