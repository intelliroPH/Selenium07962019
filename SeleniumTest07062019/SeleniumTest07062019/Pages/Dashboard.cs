using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest07062019.Lib;

namespace SeleniumTest07062019.Pages
{
    public class Dashboard
    {
        private Methods _test;

        public Dashboard(Methods methods)
        {
            _test = methods;
        }

        public By userNavIcon = By.Id("userNavigationLabel");
        public By logutLink = By.ClassName("_54nh");


        public void LogoutUser()
        {
            IWebDriver browser = _test.browser;
            browser.FindElement(userNavIcon).Click();
            Thread.Sleep(2000);
            browser.FindElement(logutLink).Click();
            Thread.Sleep(2000);


        }
    }
}
