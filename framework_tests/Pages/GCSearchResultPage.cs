﻿using System;
using OpenQA.Selenium;

namespace framework_tests
{
    public class GCSearchResultPage : WebPage
    {
        By CalculatorPageXPath = By.XPath("//div[@class='gs-title']//b[text()='Google Cloud Platform Pricing Calculator']/..");
        IWebElement _goToCalculatorPage;

        public GCSearchResultPage() : base()
        {
        }

        public GCPlatformPricingCalculator GoToCalculator()
        {
            _goToCalculatorPage = _driver.FindElement(CalculatorPageXPath);
            _goToCalculatorPage.Click();
            return new GCPlatformPricingCalculator();

        }
    }
}
