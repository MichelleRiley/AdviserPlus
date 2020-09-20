using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageObjectModels
{
    public class ResourcesPage : POMBase
    {
        public static readonly string Url = Config.baseUrl + "/resources/";

        public ResourcesPage(IWebDriver driver) : base(driver, Url)
        {

        }
    }
}
