
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_2._3
{
    public class Login
    {
        readonly By login = By.XPath(".//*[@id='mailbox:login']");
        readonly By password = By.XPath(".//*[@id='mailbox:password']");
        readonly By passwordButton = By.XPath(".//*[@class='o-control']");
        private IWebDriver _driver;

        public Login(IWebDriver driver)
        {
            this._driver = driver;
        }

        private Login InputLogin(string name)
        {
            FindElement(login).SendKeys(name);
            FindElement(passwordButton).Click();
            return this;

        }
        private Login InputPassword(string name)
        {
            FindElement(password).SendKeys(name);
            FindElement(passwordButton).Click();
            return this;
        }

       public Login LogIn(string login, string password)
        {
            Clear();
            InputLogin(login);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            InputPassword(password);
            return this;
        }
        private Login Clear()
        {
            FindElement(login).Clear();
            return this;
        }
        private IWebElement FindElement(By name) => new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(e => e.FindElement(name));
    }
}
