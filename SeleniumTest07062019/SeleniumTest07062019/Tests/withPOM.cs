using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTest07062019.Lib;
using SeleniumTest07062019.Pages;


namespace SeleniumTest07062019
{
    [TestClass]
    public class withPOM
    {

        Methods _test;
        Login _login;
        Dashboard _dash;

        [TestInitialize]
        public void setup()
        {
            _test = new Methods();
            _login = new Login(_test);
            _dash = new Dashboard(_test);
        }

        [TestMethod]
        public void LoginLogoutFB_POM()
        {
            _test.InitializeBrowser();
            _login.LoginUser();
            //wait for element sample
            _test.WaitForElement(By.ClassName("ClassName"));
            _dash.LogoutUser();
        }

        [TestMethod]
        public void SearchFB_POM()
        {
        }

        [TestCleanup]
        public void TearDown()
        {
            IWebDriver browser = _test.browser;
            browser.Quit();
        }
    }
}
