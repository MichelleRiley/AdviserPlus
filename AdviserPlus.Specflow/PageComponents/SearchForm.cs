using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageComponents
{
    public class SearchForm
    {
        private IWebDriver _driver;
        private By _searchFieldBy = By.ClassName("search-field");
        private By _searchSubmitBy = By.ClassName("search-submit");

        public SearchForm(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SearchField()
        {
            return _driver.FindElement(_searchFieldBy);
        }

        public IWebElement SearchSubmit()
        {
            return _driver.FindElement(_searchSubmitBy);
        }
    }
}
