using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationPractice.PageObjectModels
{
    public class TShirtsPage
    {
        private readonly IWebDriver _driver;
        private const string _pageUri = @"http://automationpractice.com/index.php?id_category=5&controller=category";

        public TShirtsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static TShirtsPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(_pageUri);
            return new TShirtsPage(driver);
        }

        public void ClickAddToCartButton()
        {
            _driver.FindElement(By.CssSelector("a[title='Add to cart']")).Click();
        }
    }
}
