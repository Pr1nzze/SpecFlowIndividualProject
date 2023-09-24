using BoDi;
using OpenQA.Selenium.Chrome;
using SpecFlowIndividualProject.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowIndividualProject.NewFolder
{
    [Binding]
    public sealed class BaseHooks : DriverHelper
    {
        IObjectContainer container;
        public BaseHooks(IObjectContainer _container)
        {
            container = _container;
        }

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "incognito");
            options.AddArguments(" - - no- sandbox");
            options.AddArguments(" - -disable-dev-shm-usage ");
            options.AddArgument(" - -headless ");
            Driver = new ChromeDriver(options);
            container.RegisterInstanceAs(Driver);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();  
            Driver.Dispose();
        }
    }
}