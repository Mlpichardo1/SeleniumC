using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public class SeleniumSetMethods
    {
        //Enter text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click into button
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        //Selecting Dropdown
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}