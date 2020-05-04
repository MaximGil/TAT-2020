using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_2._3
{
    class Message
    {
        readonly By WriteMessageButton = By.XPath("//span[@class='compose-button__txt']");
        readonly By whoMessage = By.XPath("//input[@tabindex='100']");
        readonly By topicMessage = By.XPath("//input[@name='Subject']");
        readonly By textMessage = By.XPath("//div[@role='textbox']/child::div[1]");
        readonly By buttonSend = By.XPath("//span[@tabindex='570']/child::span");
        readonly By buttonLogOut = By.XPath("//*[@id='PH_logoutLink']");
        readonly By saveToExample = By.XPath("//*[@tabindex='1000']");
        const string TOPIC_NAME = "test";
        const string INPUT_TEXT = "hi";
        IWebDriver _driver;
        public Message(IWebDriver driver)
        {
            _driver = driver;
        }

        private Message ClickWriteMessageButton()
        {
            FindElement(WriteMessageButton).Click();
            return this;
        }

        private Message WriteWhoMessage(string name)
        {
            FindElement(whoMessage).SendKeys(name);
            return this;
        }
        private Message WriteTopicMessage()
        {
            FindElement(topicMessage).SendKeys(TOPIC_NAME);
            return this;
        }
        private Message WriteMessageText()
        {
            FindElement(textMessage).SendKeys(INPUT_TEXT);
            return this;
        }
        private Message SendMessage()
        {
            FindElement(buttonSend).Click();
            return this;
        }
        private Message LogOut()
        {
            FindElement(saveToExample);
            FindElement(buttonLogOut).Click();
            return this;
        }
        public Message WriteMessage(string name)
        {
            ClickWriteMessageButton();
            WriteWhoMessage(name);
            WriteTopicMessage();
            WriteMessageText();
            SendMessage();
            LogOut();
            return this;
        }
        private IWebElement FindElement(By name) => new WebDriverWait(_driver,TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(name));
    }
}
