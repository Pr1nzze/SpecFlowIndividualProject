
using SpecFlowIndividualProject.Pages;

namespace SpecFlowIndividualProject.StepDefinitions 
{
    [Binding]
    public class AccountStepDefinitions : DriverHelper
    {
        AccountPage accountPage;
        public AccountStepDefinitions(IObjectContainer container)
        {
            Driver = container.Resolve<IWebDriver>();
            accountPage = container.Resolve<AccountPage>();
        }

        [When(@"I Click on login")]
        public void WhenIClickOnLogin()
        {
            accountPage.ClickLogin();
        }

        [Then(@"'([^']*)'text should be visible")]
        public void ThenTextShouldBeVisible(string prince)
        {
            string expectedText = "Logged in as Prince";
            string actualtext = accountPage.GetloggedInUserText();
            Assert.AreEqual(expectedText, actualtext);
        }


        [When(@"I Click Delete Account")]
        public void WhenIClickDeleteAccount()
        {
            accountPage.ClickDeleteAccount();
        }
    }
}
