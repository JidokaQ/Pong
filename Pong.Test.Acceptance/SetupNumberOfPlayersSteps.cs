using System;

using TechTalk.SpecFlow;

namespace Pong.Test.Acceptance
{
	[Binding]
    public class SetupNumberOfPlayersSteps
	{
		
       [Given(@"there is a game server started")]
        public void GivenThereIsAGameServerStarted()
        {
            ScenarioContext.Current.Pending();
        }
		
      [When(@"game admin selects 1000 players")]
        public void WhenGameAdminSelects1000Players()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"1000 players should be allowed entering a game")]
        public void Then_1000PlayersShouldBeAllowedEnteringAGame()
        {
            ScenarioContext.Current.Pending();
        }
	}
}
		
