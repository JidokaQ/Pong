using System;
using TechTalk.SpecFlow;
using Pong.Server;
using NUnit.Framework;

namespace Pong.Test.Acceptance
{
	[Binding]
    public class SetupNumberOfPlayersSteps
	{
		
		GameServer gameServer;
		
		[Given(@"game server is started")]
        public void GivenGameServerIsStarted()
        {
			gameServer = new GameServer();
            Assert.AreEqual(true, gameServer.IsStarted);
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
		
