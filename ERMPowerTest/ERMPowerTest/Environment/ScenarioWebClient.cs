using TechTalk.SpecFlow;

namespace ERMPowerTest.Environment
{
    [Binding]
    public static class ScenarioWebClient
    {
        [BeforeScenario("Chrome")]
        public static void SetupChrome()
        {
            ScenarioContext.Current[nameof(ScenarioWebClient)] = HostingContext.CreateChromeWebClient();
        }

        [BeforeScenario("IE")]
        public static void SetupIE()
        {
            ScenarioContext.Current[nameof(ScenarioWebClient)] = HostingContext.CreateIEWebClient();
        }

        [BeforeScenario("Firefox")]
        public static void SetupFirefox()
        {
            ScenarioContext.Current[nameof(ScenarioWebClient)] = HostingContext.CreateFirefoxWebClient();
        }
        public static WebClient GetDefaultWebClient(this ScenarioContext scenarioContext)
        {
            WebClient webClient = null;
            webClient = (WebClient)scenarioContext[nameof(ScenarioWebClient)];
            return webClient;
        }

        [AfterScenario("Chrome")]
        public static void CleanupChrome(this ScenarioContext scenarioContext)
        {
            var webClient = (WebClient)scenarioContext[nameof(ScenarioWebClient)];
            if (webClient.chromeWebDriver != null)
            {
                webClient.chromeWebDriver.Close();
            }
        }

        [AfterScenario("Firefox")]
        public static void CleanupFirefox(this ScenarioContext scenarioContext)
        {
            var webClient = (WebClient)scenarioContext[nameof(ScenarioWebClient)];
            if (webClient.firefoxWebDriver != null)
            {
                webClient.firefoxWebDriver.Close();
            }
        }

        [AfterScenario("IE")]
        public static void CleanupIE(this ScenarioContext scenarioContext)
        {
            var webClient = (WebClient)scenarioContext[nameof(ScenarioWebClient)];
            if (webClient.IEWebDriver != null)
            {
                webClient.IEWebDriver.Close();
            }
        }

    }
}
