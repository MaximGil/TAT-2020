using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace DEV_2._3
{
    class EntryPoint
    {


        static void Main(string[] args)
        {
            IWebDriver driverSender = new ChromeDriver();
            HomePage homePage = new HomePage(driverSender);
            Login loginSender = new Login(driverSender);
            loginSender.LogIn(Constans._senderLogin, Constans._senderPassword);
            Message message = new Message(driverSender);
            message.WriteMessage(Constans._receiverLogin);
            
            Login login = new Login(driverSender);
            login.LogIn(Constans._receiverLogin, Constans._receiverPassword);
            var answer = new Answer(driverSender);
            answer.AnswerMail();

            loginSender.LogIn(Constans._senderLogin, Constans._senderPassword);
            var nickname = new Nickname(driverSender);
            string newName =  nickname.GetNickname();
            System.Console.WriteLine(newName);

            var settings = new Settings(driverSender);
            settings.OpenSettings();
            settings.OpenPrivacyData();
            settings.SetNewNickname(newName);
        }
    }
}
