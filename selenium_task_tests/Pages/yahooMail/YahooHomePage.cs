﻿using OpenQA.Selenium;

namespace SeleniumTaskTests
{
    public class YahooHomePage : WebPage
    {
        static string GoToLogInPageXPath = "//input[@name='crumb']/following-sibling::a[text()='Sign in']";

        IWebElement _goToLoginPages;

        public YahooHomePage() : base()
        {
            _goToLoginPages = FindElementByXPath(GoToLogInPageXPath);
        }

        public YahooLogInPages GoToLogIn()
        {
            _goToLoginPages.Click();
            return new YahooLogInPages();
        }
    }
}

