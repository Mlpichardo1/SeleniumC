using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            // Navigate to google
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            System.Console.WriteLine("opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Login to Application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");
            pageEA.FillUserForm("MP", "Manny", "Automation");
        }

        [Test]
        public void NextTest()
        {
            System.Console.WriteLine("next method");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            System.Console.WriteLine("close browser");
        }
    }
}
