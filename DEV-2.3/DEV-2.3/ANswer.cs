using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_2._3
{
    class Answer
    {
        readonly By openMailButton = By.XPath("//*[@class='llc__content']");
        readonly By answerButton = By.XPath("//*[@title='Ответить']");
        readonly By answerText = By.XPath("//*[@tabindex='505']");
        readonly By buttonLogOut = By.XPath("//*[@id='PH_logoutLink']");
        readonly By saveToExample = By.XPath("//*[@tabindex='1000']");
        readonly By send = By.XPath("//*[@tabindex='570']");
        


        IWebDriver _driver;
        string nickname = "Mrs.Smith";

        public Answer(IWebDriver driver)
        {
            _driver = driver;
        }
        private Answer OpenMail()
        {
            FindElement(openMailButton).Click();
            return this;
        }
        private Answer AnswerClick()
        {
            FindElement(answerButton).Click();
            return this;
        }

        private Answer InputText()
        {
            FindElement(answerText).SendKeys(nickname);
            FindElement(send).Click();
            return this;
        }
        private Answer LogOut()
        {
            FindElement(saveToExample);
            FindElement(buttonLogOut).Click();
            return this;
        }
        public Answer AnswerMail()
        {
            OpenMail();
            AnswerClick();
            InputText();
            LogOut();
            return this;
        }
        private IWebElement FindElement(By name) => new WebDriverWait(_driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(name));
    }
}
