using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest07062019.Lib;

namespace SeleniumTest07062019.Pages
{
    public class Login
    {
        //instantiate si methods
        private Methods _test;

        //gagamitin ni Login yung objects ni Methods
        public Login(Methods methods)
        {
            _test = methods;
        }

        public string email = "webdrivertest101@gmail.com";
        public string pw = "Fbtest101";
        public By emailAdd = By.Name("email");
        public By password = By.Name("pass");


        public void LoginUser()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(emailAdd).SendKeys(email);
            browser.FindElement(password).SendKeys(pw + Keys.Enter);
            Thread.Sleep(5000);

        }


    }
}
