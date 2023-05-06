using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SharelaneAutomation.Page;
using Core.Selenium;

namespace SharelaneAutomation.Tests
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; } = Browser.Instance.Driver;
        public LoginPage LoginPage { get; set; }
        public SignUpPage SignUpPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            LoginPage = new LoginPage(Driver);
            SignUpPage = new SignUpPage(Driver);
            Driver.Navigate().GoToUrl("https://www.sharelane.com/cgi-bin/main.py");
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}

