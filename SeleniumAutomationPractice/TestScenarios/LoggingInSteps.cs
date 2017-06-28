using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomationPractice.PageObjectModels;
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
            //TODO: Create a WebDriver factory so we can return a Firefox, Chrome or IE.etc. driver based on config!
            _driver = new ChromeDriver();
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
            Assert.Equal("An email address required.", _signInPage.EmailAddressRequiredErrorMessage());
        }

        [AfterScenario]
        public void Teardown()
        {
            _driver.Dispose();
        }
    }
}
