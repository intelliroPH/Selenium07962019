using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumTest07062019
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CloseFacebook()
        {
            IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
            browser.Navigate().GoToUrl("https://facebook.com/");
            browser.Quit();
        }
    }
}
