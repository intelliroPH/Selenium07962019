using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace SeleniumTest070619
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenFB()
        {
            //open browser
            IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
            browser.Navigate().GoToUrl("http://web.facebook.com");

            //firstname
            browser.FindElement(By.Name("firstname")).SendKeys("Rouella");
            //lastname
            browser.FindElement(By.Name("lastname")).SendKeys("Macairan");
            //number 
            browser.FindElement(By.Name("reg_email__")).SendKeys("09171234567");
            //pw 
            browser.FindElement(By.Name("reg_passwd__")).SendKeys("123456Test" + Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab);
            //gender u_0_8
            IWebElement radioBtn = browser.FindElement(By.Id("u_0_8"));
            radioBtn.Click();
            //fb logo
            IWebElement fblogo = browser.FindElement(By.ClassName("fb_logo img sp_d8Bh2yMmHyd_2x sx_54110b"));

            //assertions
            Assert.IsTrue(radioBtn.Displayed);
            Assert.IsTrue(fblogo.Displayed);

            Thread.Sleep(5000);
            browser.Quit();
        }

        [TestMethod]
        public void RegisterIO()
        {
            List<userdetails> UserInput = new List<userdetails>();
            UserInput = EnterUser();

            foreach (var item in UserInput)
            {
                //open browser
                IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
                browser.Navigate().GoToUrl("https://iomanila-6ff2b.web.app/");
                browser.Manage().Window.Maximize();
                Thread.Sleep(5000);

                //email
                browser.FindElement(By.Id("emailField")).SendKeys(item.Email);
                //pw
                browser.FindElement(By.Id("passwordField")).SendKeys(item.Password);
                //register
                browser.FindElement(By.ClassName("registerBtn")).Click();
                Thread.Sleep(3000);

                browser.Quit();
            }


        }

        [TestMethod]
        public void LoginIO()
        {
        
            List<userdetails> UserInput = new List<userdetails>();
            UserInput = EnterUser();

            foreach (var item in UserInput)
            {
                //open browser
                IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
                browser.Navigate().GoToUrl("https://iomanila-6ff2b.web.app/");
                browser.Manage().Window.Maximize();
                Thread.Sleep(5000);

                //email
                browser.FindElement(By.Id("emailField")).SendKeys(item.Email);
                //pw
                browser.FindElement(By.Id("passwordField")).SendKeys(item.Password);
                //login
                browser.FindElement(By.ClassName("loginBtn")).Click();
                Thread.Sleep(5000);

                //welcome login message
                string welcomeMessage = browser.FindElement(By.CssSelector("#Content > p:nth-child(2)")).Text;

                Assert.AreEqual("Logged in successfully, uranus@ml.com", welcomeMessage);

                browser.Quit();
            }


        }

        public List<userdetails> EnterUser()
        {
            List<userdetails> UserInput = new List<userdetails>();
            userdetails person = new userdetails();
            userdetails person1 = new userdetails();
            userdetails person2 = new userdetails();
            person.Email = "asasd@asd.com";
            person.Password = "123456";
            person1.Email = "email1@domain.com";
            person1.Password = "123456";
            person2.Email = "user@domain.com";
            person2.Password = "2345678";
            UserInput.Add(person);
            UserInput.Add(person1);
            UserInput.Add(person2);

            return UserInput;
        }        
    }

    public class userdetails
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}