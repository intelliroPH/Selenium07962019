using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace SeleniumTest07062019.Lib
{
    public class Methods
    {
        public IWebDriver browser = new ChromeDriver(@"/Users/airratic/Projects/testSelenium", ChromeOptions());
        public WebDriverWait wait;
        public int wait_seconds = 120;
        //chromeoptions
        public static ChromeOptions ChromeOptions() 
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            options.AddArgument("--start-maximized");
            options.AddArgument("test-type");
            options.AddArguments("--disable-web-security");
            options.AddArguments("--allow-running-insecure-content");
            options.AddArguments("--disable-extensions");
            return options;
        }


        //Define browser --chrome
        public string fburl = "http://web.facebook.com";


        //Open Facebook method
        public void InitializeBrowser()
        {
            browser.Navigate().GoToUrl(fburl);
        }

        //Wait for element
        public void WaitForElement(By element)
        {
            IWebElement x = wait.Until(ExpectedConditions.ElementIsVisible(element));
        }
    }
}
