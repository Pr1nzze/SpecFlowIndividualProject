
using SpecFlowIndividualProject.Support;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowIndividualProject.StepDefinitions 
{
    [Binding]
    public class SignUpStepDefinitions : DriverHelper
    {
        SignUpPage signUpPage;
        public SignUpStepDefinitions(IObjectContainer container )
        {
            Driver = container.Resolve<IWebDriver>();
            signUpPage = container.Resolve<SignUpPage>();
        }

        [When(@"I Click the '([^']*)' option for the Title")]
        public void WhenIClickTheOptionForTheTitle(string p0)
        {
            signUpPage.ClickTitle();
        }

        [When(@"I fill in the following datas '([^']*)'")]
        public void WhenIFillInTheFollowingDatas(string password)
        {
            signUpPage.EnterNameEmailAndPass(password);
        }


        [When(@"I select '([^']*)' from the Day of birth dropdown menu")]
        public void WhenISelectFromTheDayOfBirthDropdownMenu(string day)
        {
            signUpPage.SelectDayOfBirth(day);
        }

        [When(@"I select '([^']*)' from the Month of birth dropdown menu")]
        public void WhenISelectFromTheMonthOfBirthDropdownMenu(string month)
        {
            signUpPage.SelectMonthOfBirth(month);
        }

        [When(@"I select '([^']*)' from the Year of birth dropdown menu")]
        public void WhenISelectFromTheYearOfBirthDropdownMenu(string year)
        {
            signUpPage.SelectYearOfBirth(year);
        }

        [When(@"I Select checkbox Sign up for our newsletter")]
        public void WhenISelectCheckboxSignUpForOurNewsletter()
        {
            signUpPage.ClickToReceiveNewsLetter();
        }

        [When(@"I Select checkbox Receive special offers from our partners")]
        public void WhenISelectCheckboxReceiveSpecialOffersFromOurPartners()
        {
            signUpPage.CLickToOptIn();
        }

        [When(@"I Enter the following form details '([^']*)' , '([^']*)' , '([^']*)' , '([^']*)' , '([^']*)' , '([^']*)' , '([^']*)' , '([^']*)' , '([^']*)'")]
        public void WhenIEnterTheFollowingFormDetails(string firstName, string lastName, string company, string address, string address2, string state, string city, string zipcode, string mobileNumber)
        {
            signUpPage.FillFormDetails();
        }


        [When(@"And I select '([^']*)' from the Country dropdown menu")]
        public void WhenAndISelectFromTheCountryDropdownMenu(string uSA)
        {
            signUpPage.SelectCountry(uSA);
        }

        [When(@"I click Create Account button")]
        public void WhenIClickCreateAccountButton()
        {
           signUpPage.ClickCreateAccountButton();
        }

        [Then(@"ACCOUNT CREATED! text should be displayed")]
        public void ThenACCOUNTCREATEDTextShouldBeDisplayed()
        {
            var accountCreatedElement = signUpPage.GetAccountCreatedMessageElement();
            accountCreatedElement.AssertElementText("ACCOUNT CREATED!");
        }
    }
}
