using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowIndividualProject.Support
{
    public static class CustomExtensions
    {
        /// <summary>
        /// This method will click an element
        /// </summary>
        /// <param name="element"></param>
        public static void ClickMyElement(this  IWebElement element) => element.Click();

        /// <summary>
        /// This method will allow me to enter text
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterTextToElement(this IWebElement element, string value) => element.SendKeys(value);

        /// <summary>
        /// This method will find an element with wait
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static IWebElement FindThisElement(this IWebDriver driver, By locator) 
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
