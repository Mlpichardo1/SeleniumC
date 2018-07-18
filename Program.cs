using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        // static void Main(string[] args)
        // {
        // }

        [SetUp]
        public void Initialize()
        {
            //IWebDriver driver = new ChromeDriver(@”C:\chromedriver”);
            PropertiesCollection.driver = new ChromeDriver(@"/Users/jennypichardo/Desktop/visProjects/SeleniumC/SeleniumFirst/bin/Debug/netcoreapp2.1");
            // Navigate to google
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            System.Console.WriteLine("opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"/Users/jennypichardo/Desktop/Data.xlsx");

            // Login to Application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));
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
