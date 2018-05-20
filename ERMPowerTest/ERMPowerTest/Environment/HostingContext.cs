using System;
using TechTalk.SpecFlow;

namespace ERMPowerTest.Environment
{
    [Binding]
    public class HostingContext
    {
        [BeforeTestRun(Order = 1)]
        public static void Setup()
        {
        }

        [AfterTestRun]
        public static void Teardown()
        {
        }

        public static HttpClient CreateHttpClient()
        {
            return HttpClient.Instance;
        }

        public static WebClient CreateChromeWebClient()
        {
            WebClient webClient = new WebClient();
            ChromeWebClient chromeWebClient = new ChromeWebClient();
            webClient.chromeWebDriver = chromeWebClient.GetChromeWebDrive();
            webClient.chromeWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webClient.chromeWebDriver.Manage().Window.Maximize();
            return webClient;
        }

        public static WebClient CreateFirefoxWebClient()
        {
            WebClient webClient = new WebClient();
            FirefoxWebClient firefoxWebClient = new FirefoxWebClient();
            webClient.firefoxWebDriver = firefoxWebClient.GetFirefoxWebDrive();
            webClient.firefoxWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webClient.firefoxWebDriver.Manage().Window.Maximize();
            return webClient;
        }

        public static WebClient CreateIEWebClient()
        {
            WebClient webClient = new WebClient();
            IEWebClient ieWebClient = new IEWebClient();
            webClient.IEWebDriver = ieWebClient.GetIEWebDrive();
            webClient.IEWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webClient.IEWebDriver.Manage().Window.Maximize();
            return webClient;
        }
    }
}
