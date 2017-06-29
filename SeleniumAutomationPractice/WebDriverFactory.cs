using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationPractice
{
    public class WebDriverFactory
    {
        public static IWebDriver Create(string browserDriverType)
        {
            switch (browserDriverType)
            {
                case "ChromeDriver":
                    return new ChromeDriver();
                default:
                    throw new ArgumentOutOfRangeException(browserDriverType);
            }
        }
    }
}
