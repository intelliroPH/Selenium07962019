using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumTest07062019
{
    [TestClass]
    public class NoPOM
    {
        public string pw = "Fbtest101";

        [TestMethod]
        public void LoginLogoutFB()
        {
            //open browser
            IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
            browser.Navigate().GoToUrl("http://web.facebook.com");

            //login
            browser.FindElement(By.Name("email")).SendKeys("webdrivertest101@gmail.com");
            browser.FindElement(By.Name("pass")).SendKeys(pw + Keys.Enter);

            //logout
            IWebElement userNav = browser.FindElement(By.Id("userNavigationLabel"));
            Assert.IsTrue(userNav.Displayed);
            Thread.Sleep(5000);
            userNav.Click();
            Thread.Sleep(2000); 
            browser.FindElement(By.ClassName("_54nh")).Click();

            browser.Quit();
        }

        [TestMethod]
        public void SearchFB()
        {
            //open browser
            IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
            browser.Navigate().GoToUrl("http://web.facebook.com");

            //login
            browser.FindElement(By.Name("email")).SendKeys("webdrivertest101@gmail.com");
            browser.FindElement(By.Name("pass")).SendKeys(pw + Keys.Enter);
            Thread.Sleep(5000);

            //search field
            browser.FindElement(By.Name("q")).SendKeys("Intelliro PH" + Keys.Enter);
            Thread.Sleep(5000);

            //logout
            IWebElement userNav = browser.FindElement(By.Id("userNavigationLabel"));
            Assert.IsTrue(userNav.Displayed);
            Thread.Sleep(5000);
            userNav.Click();
            Thread.Sleep(2000);

            browser.FindElement(By.ClassName("_54nh")).Click();

            browser.Quit();
        }
    }
}
