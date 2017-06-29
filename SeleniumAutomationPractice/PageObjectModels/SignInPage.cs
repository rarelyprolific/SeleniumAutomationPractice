using OpenQA.Selenium;

namespace SeleniumAutomationPractice.PageObjectModels
{
    public class SignInPage
    {
        private readonly IWebDriver _driver;
        private const string _pageUri = @"http://automationpractice.com/index.php?controller=authentication&back=my-account";

        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static SignInPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(_pageUri);
            return new SignInPage(driver);
        }

        public string EmailAddressRequiredErrorMessage => _driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li")).Text;

        public void ClickSignInButton()
        {
            _driver.FindElement(By.Id("SubmitLogin")).Click();
        }

    }
}
