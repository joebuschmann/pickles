﻿using Should;
using TechTalk.SpecFlow;

namespace Specs.CallingStepsFromSteps
{
    [Binding]
    public class CallingStepsFromStepDefinitionSteps : Steps // NOTE the inheritance
    {
        [BeforeScenario]
        public void ScenarioSetup()
        {
            ScenarioContext.Current["stepcount"] = 0;
        }

        [Given(@"I am on the index page")]
        public void GivenIAmOnTheIndexPage()
        {
            incStepCount();
        }

        [When(@"I enter my unsername nad password")]
        public void WhenIEnterMyUnsernameNadPassword()
        {
            incStepCount();
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            incStepCount();
        }

        [Then(@"the welcome page should be displayed")]
        public void ThenTheWelcomePageShouldBeDisplayed()
        {
            int i = ((int)ScenarioContext.Current["stepcount"]);
            i.ShouldEqual(3);
        }

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            Given("I am on the index page");
            When("I enter my unsername nad password");
            And("I click the login button");
            incStepCount();
        }

        [When(@"I dosomething meaningful")]
        public void WhenIDosomethingMeaningful()
        {
            incStepCount();
        }

        [Then(@"I should get rewarded")]
        public void ThenIShouldbeRewarded()
        {
            int i = ((int)ScenarioContext.Current["stepcount"]);
            i.ShouldEqual(5);
        }

        private void incStepCount()
        {
            int i = ((int)ScenarioContext.Current["stepcount"]);
            ScenarioContext.Current["stepcount"] = ++i;
        }
    }
}