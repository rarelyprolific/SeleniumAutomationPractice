using SeleniumAutomationPractice.PageObjectModels;
using SeleniumAutomationPractice.TestScenarios;
using TechTalk.SpecFlow;
using Xunit;

namespace SeleniumAutomationPractice
{
    [Binding]
    public class LoggingInSteps : TestScenario
    {
        private SignInPage _signInPage;

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

    }
}
