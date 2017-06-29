using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumAutomationPractice.TestScenarios
{
    [Binding]
    public class TestScenario
    {
        protected IWebDriver _driver;

        [BeforeScenario]
        public void Setup()
        {
            _driver = WebDriverFactory.Create(ConfigurationManager.AppSettings["BrowserDriver"]);
        }

        [AfterScenario]
        public void Teardown()
        {
            _driver.Dispose();
        }
    }
}
