using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public class SeleniumSetMethods
    {
        //Enter text
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
            driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into button
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
            driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
            driver.FindElement(By.Name(element)).Click();
        }

        //Selecting Dropdown
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
            new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}