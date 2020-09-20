using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageObjectModels
{
    public class OurSolutionsPage : POMBase
    {
        public static readonly string Url = Config.baseUrl + "/our-solutions/";

        public OurSolutionsPage(IWebDriver driver) : base(driver, Url)
        {

        }
    }
}
