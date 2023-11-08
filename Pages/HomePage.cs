using SpecFlowIndividualProject.Support;

namespace SpecFlowIndividualProject.Pages
{

    public class HomePage : DriverHelper
    {
        ReadJsonData readJsonData;
        public HomePage(IObjectContainer container)
        {
            Driver = container.Resolve<IWebDriver>();
            readJsonData = container.Resolve<ReadJsonData>();
        }

        IWebElement HomeLink => Driver.FindThisElement(By.LinkText("Home"));
        IWebElement SignUp => Driver.FindThisElement(By.XPath("//a[@href=\'/login\']"));
        IWebElement signUpName => Driver.FindThisElement(By.XPath("//input[@data-qa=\'signup-name\']"));
        IWebElement SignUpEmail => Driver.FindThisElement(By.XPath("//input[@data-qa=\'signup-email\']"));
        IWebElement SignUpButton => Driver.FindThisElement(By.XPath("//button[@data-qa=\'signup-button\']"));



        public void GoToPage() => Driver.Navigate().GoToUrl(readJsonData.readData("env:url"));
        public bool IsHomeLinkDisplayed() => HomeLink.Displayed;
        public void ClickSignUp() => SignUp.ClickMyElement();

        public string GetNewUserSignUpText()
        {
            IWebElement newUserSignUpText = Driver.FindThisElement(By.XPath("//h2[text()='New User Signup!']"));
            return newUserSignUpText.Text;
        } 

        public void EnterSignUpData(string name, string email) 
        {
            var _name = readJsonData.readData("UserDetails:Name");
            var _email = readJsonData.readData("UserDetails:Email");
            signUpName.EnterTextToElement(_name);
            SignUpEmail.EnterTextToElement(_email);
        }

        public void ClickSignUpButton() => SignUpButton.ClickMyElement();

        public string GetEnterAccountInfoText()
        {
            IWebElement enterAccountInfoText = Driver.FindThisElement(By.XPath("//b[text()='Enter Account Information']"));
            return enterAccountInfoText.Text;
        }
    }
}
