using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_2._3
{
    class Nickname
    { 
        readonly By newName = By.XPath("//div[@data-signature-widget='container']/following-sibling::div");
        readonly By openMailButton = By.XPath("//*[@class='llc__content']");
        IWebDriver driver;

        public Nickname(IWebDriver driver)
        {
            this.driver = driver;
        }

        private Nickname OpenMail()
        {
            FindElement(openMailButton).Click();
            return this;
        }
        private string GetName()
        {
            return FindElement(newName).Text.ToString();
        }
        public string GetNickname()
        {
            OpenMail();
            return GetName();
        }
        private IWebElement FindElement(By name) => new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(name));
    }
}

