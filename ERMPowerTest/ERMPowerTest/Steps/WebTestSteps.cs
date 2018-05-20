using TechTalk.SpecFlow;
using ERMPowerTest.Environment;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERMPowerTest.Steps
{
    [Binding]
    public class WebTestSteps
    {
        [Given(@"I use web driver to test web application located at '(.*)'")]
        public void GivenIUseWebDriverToTestWebApplicationLocatedAt(string webUrl)
        {
            WebClient webClient = null;
            webClient = ScenarioContext.Current.GetDefaultWebClient();
            var webDriver = SelectWebDriver(webClient);
            Assert.IsNotNull(webDriver);
            webDriver.Navigate().GoToUrl(webUrl);
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
