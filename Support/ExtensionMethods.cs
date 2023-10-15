using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowIndividualProject.Support
{
    public static class ExtensionMethods
    {
        public static void AssertElementText(this IWebElement element, string expectedText)
        {
            Assert.AreEqual(expectedText, element.Text, $"Expected text is {expectedText}, but got {element.Text}");
        }

        public static void ScrollIntoViewAndClick(this IWebDriver driver, By by)
        {
            var element = driver.FindElement(by);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            new Actions(driver).MoveToElement(element).Click().Perform();
        }

    }
}
