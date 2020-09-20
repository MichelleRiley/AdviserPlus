using AdviserPlus.Specflow.PageComponents;
using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageObjectModels
{
    public class POMBase
    {
        private readonly string _url;
        protected IWebDriver _driver;
        public Header Header;

        public POMBase(IWebDriver driver, string url)
        {
            _url = url;
            _driver = driver;
            Header = new Header(_driver);
        }

        public void GoToPage()
        {
            _driver.Navigate().GoToUrl(_url);
        }
    }
}
