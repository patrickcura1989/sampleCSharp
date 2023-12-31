﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Test.Page
{
    public class BasePage
    {
        private readonly IWebDriver _driver;

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        protected IWebDriver Getdriver()
        {
            return _driver;
        }

        protected void WaitUntilElementVisible(By by)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected IWebElement GetElement(By by)
        {
            WaitUntilElementVisible(by);
            return _driver.FindElement(by);
        }

        protected void Click(By by)
        {
            WaitUntilElementVisible(by);
            _driver.FindElement(by).Click();
        }

        protected void SendKeys(By by, string text)
        {
            WaitUntilElementVisible(by);
            _driver.FindElement(by).SendKeys(text);
        }

        protected void AcceptAlert()
        {
            IAlert alert = _driver.SwitchTo().Alert();
            alert.Accept();
        }

        protected void DismissAlert()
        {
            IAlert alert = _driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        protected void SendTextToAlertThenAccept(string text)
        {
            IAlert alert = _driver.SwitchTo().Alert();
            alert.SendKeys(text);
            alert.Accept();
        }
    }
}