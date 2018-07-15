using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumFirst
{
    public class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            //Username
            txtUserName.SendKeys(userName);
            //Password
            txtPassword.SendKeys(password);
            //Click Button
            btnLogin.Submit();

            // return the oage object
            return new EAPageObject();
        }
    }
}