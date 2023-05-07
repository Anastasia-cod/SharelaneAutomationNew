using System;
using Core.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SharelaneAutomation.Page
{
    public class UserPersonalAccountPage : BasePage
    {
        By LogoutLinkLocator = By.XPath("//a[text()='Logout']");

        public UserPersonalAccountPage() : base()
        {
            Assert.IsTrue(CheckLogoutLink());
        }

        public bool CheckLogoutLink()
        {
            return Driver.FindElement(LogoutLinkLocator).Displayed;
        }
    }
}

