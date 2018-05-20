using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace ERMPowerTest.PageObjects
{
    public class HomePageObjects
    {
        public IWebDriver driver;

        public string registerLinkCss = "a.ico-register";

        public IWebElement registerLink;

        public void ClickRegisterLink(IWebDriver driver)
        {
            this.driver = driver;
            registerLink = driver.FindElement(By.CssSelector(registerLinkCss));
            registerLink.Click();
        }
    }
}
