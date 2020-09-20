using AdviserPlus.Specflow.PageComponents;
using AdviserPlus.Specflow.PageObjectModels;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AdviserPlus.Specflow.Features
{
    [Binding]
    public sealed class MainNavigation
    {
        private IWebDriver _driver;
        public MainNavigation(IWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"core pages are displayed in the main navigation")]
        public void ThenCorePagesAreDisplayedInTheMainNavigation(Table table)
        {
            var header = new Header(_driver);
            int i;
            for (i = 0; i < table.RowCount; i++)
            {
                string page = table.Rows[i][0];
                var navitem = header.SiteNavItemsText(i);
                header.SiteNavItemsText(i).Text.Should().Be(page);               
            }
        }

        [Then(@"the hamburger navigation icon is present")]
        public void ThenTheHamburgerNavigationIconIsPresent()
        {
            var homepage = new HomePage(_driver);
            homepage.Header.HamburgerNavigation().Displayed.Should().BeTrue();
        }
    }
}
