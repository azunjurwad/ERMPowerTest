using OpenQA.Selenium.Firefox;

namespace ERMPowerTest.Environment
{
    public class FirefoxWebClient:WebClient
    {
        public FirefoxDriver GetFirefoxWebDrive()
        {
            var webClient = new WebClient();
            webClient.firefoxWebDriver = new FirefoxDriver();
            return webClient.firefoxWebDriver;
        }
    }
}
