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
        public LoginPage LoginPage { get; set; }
        public SignUpPage SignUpPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            LoginPage = new LoginPage();
            SignUpPage = new SignUpPage();
            //Browser.Instance.Driver.Navigate().GoToUrl("https://www.sharelane.com/cgi-bin/main.py");
            Browser.Instance.NavigateToUrl("https://www.sharelane.com/cgi-bin/main.py");
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}

