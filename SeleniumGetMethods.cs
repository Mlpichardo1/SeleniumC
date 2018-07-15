using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string element, string elementtype)
        {
            if(elementtype == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if(elementtype == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }

        public static string GetTextFromDDL(IWebDriver driver, string element, string elementtype)
        {
            if(elementtype == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if(elementtype == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}