using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        // Create reference for driver
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            // Navigate to google
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            System.Console.WriteLine("opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
          //Title
          SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

          //Initial
          SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

          System.Console.WriteLine("the value of my title is: " + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));
          System.Console.WriteLine("the value of my initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));
          // Click
          SeleniumSetMethods.Click(driver, "Save", "Name");
        }

        [Test]
        public void NextTest()
        {
            System.Console.WriteLine("next method");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            System.Console.WriteLine("close browser");
        }
    }
}
