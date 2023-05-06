using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Core.Selenium
{
    public class Browser
    {
        private static Browser instance = null;
        private IWebDriver driver;

        public static Browser Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Browser();
                }
                return instance;
            }
        }

        public IWebDriver Driver { get { return driver;  } }

        private Browser()
        {
            switch (TestContext.Parameters.Get("Browser"))
            {
                case "chrome":
            
                    if(bool.Parse(TestContext.Parameters.Get("Headless")!))
                    {
                        ChromeOptions options = new ChromeOptions();
                        options.AddArgument("--headless");
                        driver = new ChromeDriver(options);
                    }
                    else
                    {
                        driver = new ChromeDriver();
                    }
                    
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void CloseBrowser()
        {
            driver?.Dispose();
            instance = null;
        }   
    }
}

