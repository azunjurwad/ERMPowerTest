using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ERMPowerTest.Environment
{
    [Binding]
    public static class ScenarioHttpClient
    {
        [BeforeScenario(Order = 1)]
        public static void Setup()
        {
            ScenarioContext.Current[nameof(ScenarioHttpClient)] = HostingContext.CreateHttpClient();
        }

        public static HttpClient GetHttpClient(this ScenarioContext scenarioContext)
        {
            return (HttpClient)scenarioContext[nameof(ScenarioHttpClient)];
        }

        [AfterScenario]
        public static void Teardown()
        {
            ScenarioContext.Current[nameof(ScenarioHttpClient)] = null;
        }
    }
}
