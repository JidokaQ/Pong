using System;

using TechTalk.SpecFlow;

namespace Pong2.Test.Acceptance
{
	[Binding]
    public class SetupNumbersOfPlayers
	{ 
		[Given(@"you are not in another game")]
        public void GivenYouAreNotInAnotherGame()
        {
            ScenarioContext.Current.Pending();
        }
		
		[When(@"user choose 2 player")]
        public void WhenUserChoose2Player()
        {
            ScenarioContext.Current.Pending();
        } 

		[Then(@"2 paddles should be in the game")]
        public void Then_2PaddlesShouldBeInTheGame()
        {
            ScenarioContext.Current.Pending();
        }
	}
}
		
