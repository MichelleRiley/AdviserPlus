using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AdviserPlus.Specflow.Features
{
    [Binding]
    public sealed class AUserCanSearchTheWebsite
    {
        private IWebDriver _driver = new ChromeDriver();

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            _driver.Navigate().GoToUrl("https://adviserplus.com/");
            _driver.Dispose();
        }
    }
}
