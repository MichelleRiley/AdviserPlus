using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageObjectModels
{
    public class HowWeHelpPage : POMBase
    {
        public static readonly string Url = Config.baseUrl + "/how-we-help/";

        public HowWeHelpPage(IWebDriver driver) : base(driver, Url)
        {

        }
    }
}
