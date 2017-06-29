using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomationPractice.PageObjectModels;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace SeleniumAutomationPractice
{
    [Binding]
    public class AddingTShirtToBasketSteps
    {
        private IWebDriver _driver;
        private TShirtsPage _tShirtsPage;
        private CartPage _cartPage;

        [BeforeScenario]
        public void Setup()
        {
            //TODO: Create a WebDriver factory so we can return a Firefox, Chrome or IE.etc. driver based on config!
            _driver = new ChromeDriver();
        }

        [Given(@"I am in the t-shirts page")]
        public void GivenIAmInTheT_ShirtsPage()
        {
            _tShirtsPage = TShirtsPage.NavigateTo(_driver);
        }
        
        [Given(@"I have clicked ""(.*)"" on the t-shirt")]
        public void GivenIHaveClickedOnTheT_Shirt(string p0)
        {
            Thread.Sleep(1000); //TODO: Get rid of this later when I figure out how to get WebDriver to wait for DOM changes/page loads
            _tShirtsPage.ClickAddToCartButton();
        }
        
        [When(@"I go to the shopping cart page")]
        public void WhenIGoToTheShoppingCartPage()
        {
            Thread.Sleep(1000); //TODO: Get rid of this later when I figure out how to get WebDriver to wait for DOM changes/page loads
            _cartPage = CartPage.NavigateTo(_driver);
        }
        
        [Then(@"there should be a single item in the cart which is a t-shirt")]
        public void ThenThereShouldBeASingleItemInTheCartWhichIsAT_Shirt()
        {
            Thread.Sleep(1000); //TODO: Get rid of this later when I figure out how to get WebDriver to wait for DOM changes/page loads
            Assert.Equal("1 Product", _cartPage.ProductCountText);
        }

        [AfterScenario]
        public void Teardown()
        {
            _driver.Dispose();
        }
    }
}
