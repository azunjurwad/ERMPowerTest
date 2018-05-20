using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
