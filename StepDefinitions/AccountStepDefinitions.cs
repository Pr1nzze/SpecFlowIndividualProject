
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


        //[When(@"I Click Continue")]
        //public void WhenIClickContinue()
        //{
        //    accountPage.ClickContinueButton();
        //}

        //[When(@"i Click the close button on the ad popup")]
        //public void WhenIClickTheCloseButtonOnTheAdPopup()
        //{
        //    CloseAdIfPresent();
        //}


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

        //[When(@"I close Ad pop up")]
        //public void WhenICloseAdPopUp()
        //{
        //   CloseAdIfPresent();
        //}


        //[Then(@"ACCOUNT DELETED! text should be visible")]
        //public void ThenACCOUNTDELETEDTextShouldBeVisible()
        //{
        //    string expectedText = "ACCOUNT DELETED!";
        //    string actualtext = accountPage.GetAccountDeletedText();
        //    Assert.AreEqual(expectedText, actualtext);
        //}

        //[Then(@"I click Continue button")]
        //public void ThenIClickContinueButton()
        //{
        //    accountPage.ClickContinueBtn();
        //}
    }
}
