using OpenQA.Selenium.IE;

namespace ERMPowerTest.Environment
{
    public class IEWebClient:WebClient
    {
        public InternetExplorerDriver GetIEWebDrive()
        {
            var webClient = new WebClient();
            webClient.IEWebDriver = new InternetExplorerDriver();
            return webClient.IEWebDriver;
        }
    }
}
