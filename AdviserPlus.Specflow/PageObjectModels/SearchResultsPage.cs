using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageObjectModels
{
    public class SearchResultsPage : POMBase
    {
        public static readonly string Url = Config.baseUrl + "/?s=";

        private By _searchResultsTitleBy = By.ClassName("search-result__title");

        public SearchResultsPage(IWebDriver driver) : base(driver, Url)
        {

        }

        public IWebElement SearchResultsTitle()
        {
            return _driver.FindElement(_searchResultsTitleBy);
        }
    }
}
