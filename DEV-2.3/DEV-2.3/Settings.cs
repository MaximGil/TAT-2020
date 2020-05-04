using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace DEV_2._3
{
   class Settings
    {
        IWebDriver _driver;
        readonly By openSettings = By.XPath("//*[@id='PH_user-email']");
        readonly By privacyData = By.XPath("//*[text()='Личные данные']");
        readonly By nickname = By.XPath("//input[@id='firstname']");
        readonly By saveButton = By.XPath("//button[@data-test-id='save-button']");

        public Settings(IWebDriver driver)
        {
            _driver = driver;
        }
        public void OpenSettings()
        {
            FindElement(openSettings).Click();
        }
        public void OpenPrivacyData()
        {
            FindElement(privacyData).Click();
        }
        public void SetNewNickname(string name)
        {
            FindElement(nickname).Clear();
            Thread.Sleep(3000);
            FindElement(nickname).SendKeys(name);
            FindElement(saveButton).Click();
        }
        private IWebElement FindElement(By name) => new WebDriverWait(_driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(name));
    }
}
