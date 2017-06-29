using OpenQA.Selenium;
using SeleniumAutomationPractice.PageObjectModels;
using System.Configuration;
using TechTalk.SpecFlow;
using Xunit;

namespace SeleniumAutomationPractice
{
    [Binding]
    public class LoggingInSteps
    {
        private IWebDriver _driver;
        private SignInPage _signInPage;

        [BeforeScenario]
        public void Setup()
        {
            _driver = WebDriverFactory.Create(ConfigurationManager.AppSettings["BrowserDriver"]);
        }

        [Given(@"I am in the sign in page")]
        public void GivenIAmInTheSignInPage()
        {
            _signInPage = SignInPage.NavigateTo(_driver);
        }
        
        [When(@"I press the Sign In button without entering any login details")]
        public void WhenIPressTheSignInButtonWithoutEnteringAnyLoginDetails()
        {
            _signInPage.ClickSignInButton();
        }

        [Then(@"I should see an error saying an email address is required")]
        public void ThenIShouldSeeAnErrorSayingAnEmailAddressIsRequired()
        {
            Assert.Equal("An email address required.", _signInPage.EmailAddressRequiredErrorMessage);
        }

        [AfterScenario]
        public void Teardown()
        {
            _driver.Dispose();
        }
    }
}
