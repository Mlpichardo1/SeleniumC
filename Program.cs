using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create reference for driver
            IWebDriver driver = new ChromeDriver(); 

            // Navigate to google
            driver.Navigate().GoToUrl("www.google.com");

            // Find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("executeautomation");

            driver.Close();
        }
    }
}
