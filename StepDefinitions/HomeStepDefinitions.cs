

namespace SpecFlowIndividualProject.StepDefinitions 
{
    [Binding]
    public class HomeStepDefinitions : DriverHelper
    {
        HomePage homePage;
        public HomeStepDefinitions(IObjectContainer container)
        {
            Driver = container.Resolve<IWebDriver>();
            homePage= container.Resolve<HomePage>();
        }

        [Given(@"I navigate to the Automation Practice url")]
        public void GivenINavigateToTheAutomationPracticeUrl()
        {
            homePage.GoToPage();
        }


        [Then(@"the home page should be visible")]
        public void ThenTheHomePageShouldBeVisible()
        {
           Assert.True(homePage.IsHomeLinkDisplayed());
        }

        [When(@"I Click on Signup / Login button")]
        public void WhenIClickOnSignupLoginButton()
        {
            homePage.ClickSignUp();
        }

        [Then(@"New User Signup! should be visible")]
        public void ThenNewUserSignupShouldBeVisible()
        {
            string expectedText = "New User Signup!";
            string actualText = homePage.GetNewUserSignUpText();
            Assert.AreEqual(expectedText, actualText);
        }

        [When(@"I fill in the following data '([^']*)' , '([^']*)'")]
        public void WhenIFillInTheFollowingData(string name, string email)
        {
            homePage.EnterSignUpData(name, email);
        }

        [When(@"I Click the Signup button")]
        public void WhenIClickTheSignupButton()
        {
            homePage.ClickSignUpButton();
        }

        [Then(@"ENTER ACCOUNT INFORMATION should be visible")]
        public void ThenENTERACCOUNTINFORMATIONShouldBeVisible()
        {
            string expectedText = "ENTER ACCOUNT INFORMATION";
            string actualtext = homePage.GetEnterAccountInfoText();
            Assert.AreEqual(expectedText, actualtext);
        }
    }
}
