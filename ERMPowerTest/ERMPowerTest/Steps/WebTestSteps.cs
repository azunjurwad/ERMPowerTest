using TechTalk.SpecFlow;
using ERMPowerTest.Environment;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using System;
using ERMPowerTest.PageObjects;

namespace ERMPowerTest.Steps
{
    [Binding]
    public class WebTestSteps
    {
        public static IWebDriver webDriver;

        [Given(@"I use web driver to test web application located at '(.*)'")]
        public void GivenIUseWebDriverToTestWebApplicationLocatedAt(string webUrl)
        {
            WebClient webClient = null;
            webClient = ScenarioContext.Current.GetDefaultWebClient();
            webDriver = SelectWebDriver(webClient);
            Assert.IsNotNull(webDriver);
            webDriver.Navigate().GoToUrl(webUrl);
        }

        [When(@"I go to registeration page")]
        public void WhenIGoToRegisterationPage()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            homePageObjects.ClickRegisterLink(webDriver);
        }

        [When(@"I provide registeration details for application access")]
        public void WhenIProvideRegisterationDetailsForApplicationAccess(Table table)
        {
            RegisterPageObjects registerPageObjects = new RegisterPageObjects();
            foreach (var row in table.Rows)
            {
                registerPageObjects.EnterFirstName(webDriver, row["FirstName"]);
                registerPageObjects.EnterLastName(webDriver, row["LastName"]);
                registerPageObjects.EnterEmail(webDriver, row["Email"]);
                registerPageObjects.EnterUserName(webDriver, row["Username"]);
                registerPageObjects.SelectCountry(webDriver, row["Country"]);
                registerPageObjects.SelectRole(webDriver, row["YourRole"]);
                registerPageObjects.DisableNewsLetter(webDriver);
                registerPageObjects.EnterPassword(webDriver, row["Password"]);
                registerPageObjects.EnterConfirmPassword(webDriver, row["ConfirmPassword"]);
                registerPageObjects.ClickRegister(webDriver);
            }
        }

        [Then(@"I should get successful registration message")]
        public void ThenIShouldGetSuccessfulRegistrationMessage()
        {
            RegisterPageObjects registerPageObjects = new RegisterPageObjects();
            registerPageObjects.RegistrationSuccess(webDriver, "Your registration has been successfully completed.\r\nYou have just been sent an email containing membership activation instructions.");
        }

        public IWebDriver SelectWebDriver(WebClient webClient)
        {
            if (webClient.firefoxWebDriver != null)
            {
                return webClient.firefoxWebDriver;
            }
            else if (webClient.chromeWebDriver != null)
            {
                return webClient.chromeWebDriver;
            }
            else if (webClient.IEWebDriver != null)
            {
                return webClient.IEWebDriver;
            }
            else return null;
        }
    }
}
