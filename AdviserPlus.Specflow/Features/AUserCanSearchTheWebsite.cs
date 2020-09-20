using AdviserPlus.Specflow.PageComponents;
using AdviserPlus.Specflow.PageObjectModels;
using FluentAssertions;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AdviserPlus.Specflow.Features
{
    [Binding]
    public sealed class AUserCanSearchTheWebsite
    {
        private IWebDriver _driver;
        private string _invalidSearchTerm = "zwxg";

        public AUserCanSearchTheWebsite(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"the search form contains an invalid value")]
        public void GivenTheSearchFormContainsAnInvalidValue()
        {
            var homePage = new HomePage(_driver);
            homePage.GoToPage();
            homePage.Header.SearchToggle().Click();
            var searchForm = new SearchForm(_driver);
            searchForm.SearchField().SendKeys(_invalidSearchTerm);
        }

        [When(@"I submit the search form")]
        public void WhenISubmitTheSearchForm()
        {
            var searchForm = new SearchForm(_driver);
            searchForm.SearchSubmit().Submit();
        }

        [Then(@"I am redirected to the results page")]
        public void ThenIAmRedirectedToTheResultsPage()
        {
            _driver.Url.Should().Be(SearchResultsPage.Url + _invalidSearchTerm);
        }

        [Then(@"""(.*)"" message is displayed")]
        public void ThenMessageIsDisplayed(string expectedMessage)
        {
            Thread.Sleep(3000);
            var searchResultsPage = new SearchResultsPage(_driver);
            searchResultsPage.SearchResultsTitle().Text.Should().Be(expectedMessage);
        }
    }
}
