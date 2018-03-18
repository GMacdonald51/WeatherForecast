using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Diagnostics;
using System.Threading;

namespace WiproTestProject.Utilities
{
    public static class Driver
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        public static void OpenBrowser(String selectedBrowser)
        {
            //This value is set in the Before Scenario Hook.
            switch(selectedBrowser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;
                default:
                    Debug.Print("Uknown driver selected");
                    break;
            }
        }

        public static void NavigateTo(string target)
        {
            driver.Navigate().GoToUrl(target);
        }

        public static void Pause(int time)
        {
            Thread.Sleep(time);
        }

        public static void WaitForElement(IWebElement element)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            
        }
        
        //Visual Studio says that ExpectedConditions is deprecated.
        //I found this is as a possible replacement, but no clear documentation found
        //about what to use instead of ExpectedConditions
        //Alternatively I could use an older version of Selenium
        //I will use the deprecated versions for now, but this is just included to show
        //That I did some investigation into this matter
        public static void WaitForElementByCSS(string cssLocator)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement elem = wait.Until(driver => driver.FindElement(By.CssSelector(cssLocator)));
           
        }

        public static string GetPageTitle()
        {
            return driver.Title;
        }

        public static void EnterText(IWebElement element, string input)
        {
            WaitForElement(element);
            element.SendKeys(input);
            
        }

        
        public static void PressEnter(IWebElement element)
        {
            element.SendKeys(Keys.Enter);
        }

        public static void clickOnElement(IWebElement element)
        {
            WaitForElement(element);
            element.Click();
        }

        public static void Quit()
        {
            driver.Quit();
        }
        
    }
}
