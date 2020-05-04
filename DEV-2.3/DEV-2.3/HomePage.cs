using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEV_2._3
{
    class HomePage
    {
        private static readonly string PATHMAIL = "https://mail.ru/";

        public HomePage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PATHMAIL);
            driver.Manage().Window.Maximize();
        }
    }
}
