using System;
using OpenQA.Selenium;

namespace SharelaneAutomation.Page
{
    public abstract class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}