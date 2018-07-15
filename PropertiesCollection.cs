using OpenQA.Selenium;

namespace SeleniumFirst
{
    enum PropertyType
        {
            Id,
            Name,
            LinkText,
            CssName,
            ClassName
        }
    public class PropertiesCollection
    {
        //Auto-Implemented Property
        public static IWebDriver driver {get; set;}
    }
}