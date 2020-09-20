using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Linq;
using TechTalk.SpecFlow;

namespace AdviserPlus.Specflow
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs(_driver, typeof(IWebDriver));

            if (_scenarioContext.ScenarioInfo.Tags.Contains("mobile"))
            {
                _driver.Manage().Window.Size = new Size(660, 768);
            }
            else
            {
                _driver.Manage().Window.Size = new Size(1080, 768);
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if(_driver != null)
            {
                _driver.Dispose();
                _driver = null;
            }
        }
    }
}
