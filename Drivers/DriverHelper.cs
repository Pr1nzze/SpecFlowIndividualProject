using OpenQA.Selenium;
using SpecFlowIndividualProject.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowIndividualProject.Drivers
{
    public class DriverHelper
    {
        public IWebDriver Driver;

        public void CloseAdIfPresent()
        {
            try
            {
                var closeButtonX = Driver.FindThisElement(By.Id("dismiss-button"));
                if (closeButtonX.Displayed)
                {
                    closeButtonX.Click();
                }
            }
            catch (NoSuchElementException)
            {
                // If the 'x' button ad isn't found, try to find and close the 'Close' button ad
                try
                {
                    var closeButton = Driver.FindThisElement(By.XPath("//span[contains(text(),'Close')]"));
                    if (closeButton.Displayed)
                    {
                        closeButton.Click();
                    }
                }
                catch (NoSuchElementException)
                {
                    // Both ads were not found. Continue with the test or log the event.
                }
            }
        }

    }

}
