using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationPractice.PageObjectModels
{
    public class CartPage
    {
        private readonly IWebDriver _driver;
        private const string _pageUrl = @"http://automationpractice.com/index.php?controller=order";

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static CartPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(_pageUrl);
            return new CartPage(driver);
        }

        public string ProductCountText => _driver.FindElement(By.Id("summary_products_quantity")).Text;
    }
}
