using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageComponents
{
    public class Header
    {
        private IWebDriver _driver;
        private By _hamburgerNavigationBy = By.ClassName("site-header__toggle-nav-icon");
        private By _siteNavigationBy = By.ClassName("site-navigation");
        private By _siteNavItemsTextBy = By.ClassName("site-navigation__link-text");
        private By _searchToggleBy = By.ClassName("search-wrap");
        
        public Header(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement HamburgerNavigation()
        {
            return _driver.FindElement(_hamburgerNavigationBy);
        }

        public IWebElement SearchToggle()
        {
            return _driver.FindElement(_searchToggleBy);
        }

        public IWebElement SiteNavigation()
        {
            return _driver.FindElement(_siteNavigationBy);
        }

        public IWebElement SiteNavItemsText(int i)
        {
            IWebElement coreSiteNav = _driver.FindElements(_siteNavigationBy)[1];
            return coreSiteNav.FindElements(_siteNavItemsTextBy)[i];
        }
    }
}
