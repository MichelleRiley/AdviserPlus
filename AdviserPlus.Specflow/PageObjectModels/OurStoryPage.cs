using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageObjectModels
{
    public class OurStoryPage : POMBase
    {
        public static readonly string Url = Config.baseUrl + "/our-story/";

        public OurStoryPage(IWebDriver driver) : base(driver, Url)
        {

        }
    }
}
