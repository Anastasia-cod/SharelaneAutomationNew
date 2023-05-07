﻿using System;
using OpenQA.Selenium;

namespace SharelaneAutomation.Page
{
    public class BookInfoPage : BasePage
    {
        By AddToCardButtonLocator = By.XPath("//img[@src='../images/add_to_cart.gif']");

        public BookInfoPage() : base()
        {
        }

        public void ClickAddToCardButton()
        {
            Driver.FindElement(AddToCardButtonLocator).Click();
        }

        public bool CheckForAddToCardButton()
        {
            return Driver.FindElement(AddToCardButtonLocator).Displayed;
        }
    }
}

