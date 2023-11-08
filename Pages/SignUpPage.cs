using OpenQA.Selenium.Support.UI;
using SpecFlowIndividualProject.Support;

namespace SpecFlowIndividualProject.Pages
{
    public  class SignUpPage : DriverHelper
    {
        ReadJsonData readJsonData;
        public SignUpPage(IObjectContainer container)
        {
            Driver = container.Resolve<IWebDriver>();
            readJsonData = container.Resolve<ReadJsonData>();
        }

        IWebElement title => Driver.FindThisElement(By.Id("id_gender1"));
        IWebElement userName => Driver.FindThisElement(By.XPath("//input[@id='name']"));
        IWebElement userEmail => Driver.FindThisElement(By.XPath("//input[@id='email']"));
        IWebElement passW => Driver.FindThisElement(By.XPath("//input[@id='password']"));
        IWebElement dayOB => Driver.FindThisElement(By.Id("days"));
        IWebElement monthOB => Driver.FindThisElement(By.Id("months"));
        IWebElement yearOB => Driver.FindThisElement(By.Id("years"));
        IWebElement newsLetter => Driver.FindThisElement(By.Id("newsletter"));
        IWebElement optin => Driver.FindThisElement(By.Id("optin"));
        IWebElement firstName => Driver.FindThisElement(By.Id("first_name"));
        IWebElement lastName => Driver.FindThisElement(By.Id("last_name"));
        IWebElement company => Driver.FindThisElement(By.Id("company"));
        IWebElement firstLineAddress => Driver.FindThisElement(By.Id("address1"));
        IWebElement secondLineAddress => Driver.FindThisElement(By.Id("address2"));
        IWebElement country => Driver.FindThisElement(By.Id("country"));
        IWebElement state => Driver.FindThisElement(By.Id("state"));
        IWebElement city => Driver.FindThisElement(By.Id("city"));
        IWebElement zipcode => Driver.FindThisElement(By.Id("zipcode"));
        IWebElement mobileNumber => Driver.FindThisElement(By.XPath("//input[@id='mobile_number']"));
        IWebElement createAccountButton => Driver.FindThisElement(By.XPath("(//button[@type='submit'])[1]"));
        IWebElement accountCreatedMessage => Driver.FindElement(By.XPath("//b[text()='Account Created!']"));

        public void ClickTitle() => title.ClickMyElement();

        public void EnterNameEmailAndPass(string password)
        {
            var uPassword = readJsonData.readData("UserDetails:Password");
            passW.EnterTextToElement(uPassword);
        }

        public void FillFormDetails()
        {
            var firstnameNameFromJson = readJsonData.readData("UserDetails:firstName");
            var lastNameNameFromJson = readJsonData.readData("UserDetails:lastName");
            var companyNameFromJson = readJsonData.readData("UserDetails:company");
            var addressNameFromJson = readJsonData.readData("UserDetails:address");
            var address2NameFromJson = readJsonData.readData("UserDetails:address2");
            var stateNameFromJson = readJsonData.readData("UserDetails:state");
            var cityNameFromJson = readJsonData.readData("UserDetails:city");
            var zipcodeNameFromJson = readJsonData.readData("UserDetails:zipcode");
            var numberNameFromJson = readJsonData.readData("UserDetails:mobileNumber");
            firstName.EnterTextToElement(firstnameNameFromJson);
            lastName.EnterTextToElement(lastNameNameFromJson);
            company.EnterTextToElement(companyNameFromJson);
            firstLineAddress.EnterTextToElement(addressNameFromJson);
            secondLineAddress.EnterTextToElement(address2NameFromJson);
            state.EnterTextToElement(stateNameFromJson);
            city.EnterTextToElement(cityNameFromJson);
            zipcode.EnterTextToElement(zipcodeNameFromJson);
            mobileNumber.EnterTextToElement(numberNameFromJson);

        }

        public void SelectDayOfBirth(string day)
        {
            SelectElement selectDay = new SelectElement(dayOB);
            selectDay.SelectByText(day);
        }

        public void SelectMonthOfBirth(string month)
        {
            SelectElement selectMonth = new SelectElement(monthOB);
            selectMonth.SelectByText(month);
        }

        public void SelectYearOfBirth(string year)
        {
            SelectElement selectYear = new SelectElement(yearOB);
            selectYear.SelectByText(year);
        }

        public void ClickToReceiveNewsLetter()
        {
            By newsLetter  = By.Id("newsletter");
            Driver.ScrollIntoViewAndClick(newsLetter);
        }
        public void CLickToOptIn() => optin.ClickMyElement();

        public void SelectCountry(string uSA)
        {
            SelectElement selectCountry = new SelectElement(country);
            selectCountry.SelectByText("United States");
        }

        public void ClickCreateAccountButton()
        {
            By createAccountButton = By.XPath("(//button[@type='submit'])[1]");
            Driver.ScrollIntoViewAndClick(createAccountButton); 
        }

        public IWebElement GetAccountCreatedMessageElement()
        {
            return accountCreatedMessage;
        }
    }
}
