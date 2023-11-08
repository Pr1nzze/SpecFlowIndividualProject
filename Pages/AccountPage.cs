using SpecFlowIndividualProject.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowIndividualProject.Pages
{
    public class AccountPage : DriverHelper
    {
        public AccountPage(IObjectContainer container)
        {
            Driver = container.Resolve<IWebDriver>();
        }

        IWebElement continueButton => Driver.FindThisElement(By.XPath("//a[@data-qa='continue-button']"));
        IWebElement deleteAccount => Driver.FindThisElement(By.XPath("//a[@href='/delete_account']")); 
        IWebElement continueBtn => Driver.FindThisElement(By.XPath("//a[@data-qa='continue-button']"));
        IWebElement login => Driver.FindThisElement(By.XPath("//a[@href=\'/login\']"));

        public void ClickLogin() => login.ClickMyElement();

        public string GetloggedInUserText()
        {
            IWebElement loggedInUserText = Driver.FindElement(By.XPath("//a[contains(text(), 'Logged in as ')]"));
            return loggedInUserText.Text;
        }

        public void ClickDeleteAccount() => deleteAccount.ClickMyElement();
    }
}
