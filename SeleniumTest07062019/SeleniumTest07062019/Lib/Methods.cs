using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest07062019.Lib
{
    public class Methods
    {
        //public void InitOne() 
        //{
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--disable-extensions"); // to disable extension
            //options.AddArguments("--disable-notifications"); // to disable notification
            //options.AddArguments("--disable-application-cache"); // to disable cache
            //IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium", options);
        //}


        //Define browser --chrome
        public IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium");
        public string fburl = "http://web.facebook.com";


        //Open Facebook method
        public void InitializeBrowser()
        {
            browser.Navigate().GoToUrl(fburl);

       }
    }
}
