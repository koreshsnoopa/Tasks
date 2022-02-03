﻿using OpenQA.Selenium;

namespace selenium_task_tests
{
    public class YahooHomePage : WebPage
    {
        static string GoToLogInPageXPath = "//input[@name='crumb']/following-sibling::a[text()='Sign in']";

        IWebElement _goToLoginPages;

        public YahooHomePage(IWebDriver driver) : base(driver)
        {
            _goToLoginPages = FindElementByXPath(GoToLogInPageXPath);
        }

        public YahooLogInPages GoToLogIn()
        {
            _goToLoginPages.Click();
            return new YahooLogInPages(_driver);
        }
    }
}
