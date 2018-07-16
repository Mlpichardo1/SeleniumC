using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public class SeleniumGetMethods
    {
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}