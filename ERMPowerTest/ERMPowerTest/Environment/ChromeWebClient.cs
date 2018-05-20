using OpenQA.Selenium.Chrome;

namespace ERMPowerTest.Environment
{
    public class ChromeWebClient:WebClient
    {
        public ChromeDriver GetChromeWebDrive()
        {
            var webClient = new WebClient();
            webClient.chromeWebDriver = new ChromeDriver();
            return webClient.chromeWebDriver;
        }

    }
}
