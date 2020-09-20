using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageObjectModels
{
    public class ContactPage : POMBase
    {
        public static readonly string Url = Config.baseUrl + "/contact/";

        public ContactPage(IWebDriver driver) : base(driver, Url)
        {

        }
    }
}
