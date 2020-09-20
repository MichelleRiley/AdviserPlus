using AdviserPlus.Specflow.PageObjectModels;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AdviserPlus.Specflow.Features
{
    [Binding]
    public class CommonSteps
    {
        private IWebDriver _driver;
        public CommonSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I am on the (.*)")]
        public void GivenIAmOnThePage(string page)
        {
            switch (page)
            {
                case "homepage":
                    _driver.Navigate().GoToUrl(HomePage.Url);
                    break;
                case "how we help":
                    _driver.Navigate().GoToUrl(HowWeHelpPage.Url);
                    break;
                case "our solutions":
                    _driver.Navigate().GoToUrl(OurSolutionsPage.Url);
                    break;
                case "our story":
                    _driver.Navigate().GoToUrl(OurStoryPage.Url);
                    break;
                case "resources":
                    _driver.Navigate().GoToUrl(ResourcesPage.Url);
                    break;
                case "contact":
                    _driver.Navigate().GoToUrl(ContactPage.Url);
                    break;
                default:
                    break;
            }
        }
    }
}
