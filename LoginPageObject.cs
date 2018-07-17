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
            txtUserName.EnterText(userName);
            //Password
            txtPassword.EnterText(password);
            //Click Button
            btnLogin.Clicks();

            // return the oage object
            return new EAPageObject();
        }
    }
}