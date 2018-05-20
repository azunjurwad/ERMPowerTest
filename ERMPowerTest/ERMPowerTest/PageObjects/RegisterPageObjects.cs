using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace ERMPowerTest.PageObjects
{
    public class RegisterPageObjects
    {
        public IWebDriver driver;

        #region element locators
        public string FirstNameId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_txtFirstName";

        public string LastNameId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_txtLastName";

        public string EmailId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_Email";

        public string UserNameId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_UserName";

        public string CountrySelectId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_ddlCountry";

        public string RoleSelectId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_ddlRole";

        public string NewsLetterId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_cbNewsletter";

        public string PasswordId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_Password";

        public string ConfirmPasswordId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_ConfirmPassword";

        public string RegisterButtonId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm___CustomNav0_StepNextButton";

        public string RegisterMessageId = "ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CompleteStepContainer_lblCompleteStep";
        #endregion
        #region web elements
        public IWebElement FirstNameElement;

        public IWebElement LastNameElement;

        public IWebElement EmailElement;

        public IWebElement UserNameElement;

        public IWebElement NewsLetterElement;

        public IWebElement PasswordElement;

        public IWebElement ConfirmPasswordElement;

        public IWebElement RegisterButtonElement;

        public IWebElement RegisterMessageElement;
        #endregion
        public void EnterFirstName(IWebDriver driver, string firstName)
        {
            this.driver = driver;
            FirstNameElement = driver.FindElement(By.Id(FirstNameId));
            FirstNameElement.SendKeys(firstName);
        }

        public void EnterLastName(IWebDriver driver, string lastName)
        {
            this.driver = driver;
            LastNameElement = driver.FindElement(By.Id(LastNameId));
            LastNameElement.SendKeys(lastName);
        }

        public void EnterEmail(IWebDriver driver, string email)
        {
            this.driver = driver;
            EmailElement = driver.FindElement(By.Id(EmailId));
            EmailElement.SendKeys(email);
        }

        public void EnterUserName(IWebDriver driver, string userName)
        {
            this.driver = driver;
            UserNameElement = driver.FindElement(By.Id(UserNameId));
            UserNameElement.SendKeys(userName);
        }

        public void SelectCountry(IWebDriver driver, string country)
        {
            this.driver = driver;
            new SelectElement(driver.FindElement(By.Id(CountrySelectId))).SelectByText(country);
        }

        public void SelectRole(IWebDriver driver, string role)
        {
            this.driver = driver;
            new SelectElement(driver.FindElement(By.Id(RoleSelectId))).SelectByText(role);
        }

        public void DisableNewsLetter(IWebDriver driver)
        {
            this.driver = driver;
            NewsLetterElement = driver.FindElement(By.Id(NewsLetterId));
            if (NewsLetterElement.Selected)
            {
                NewsLetterElement.Click();
            }
        }

        public void EnterPassword(IWebDriver driver, string password)
        {
            this.driver = driver;
            PasswordElement = driver.FindElement(By.Id(PasswordId));
            PasswordElement.SendKeys(password);
        }

        public void EnterConfirmPassword(IWebDriver driver, string password)
        {
            this.driver = driver;
            ConfirmPasswordElement = driver.FindElement(By.Id(ConfirmPasswordId));
            ConfirmPasswordElement.SendKeys(password);
        }

        public void ClickRegister(IWebDriver driver)
        {
            this.driver = driver;
            RegisterButtonElement = driver.FindElement(By.Id(RegisterButtonId));
            RegisterButtonElement.Click();
        }

        public void RegistrationSuccess(IWebDriver driver, string text)
        {
            this.driver = driver;
            RegisterMessageElement = driver.FindElement(By.Id(RegisterMessageId));
            Assert.AreEqual(text, RegisterMessageElement.Text);
        }
    }
}
