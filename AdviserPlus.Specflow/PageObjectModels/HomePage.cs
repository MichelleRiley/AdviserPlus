using OpenQA.Selenium;

namespace AdviserPlus.Specflow.PageObjectModels
{
    public class HomePage : POMBase
    {  
        public static readonly string Url = Config.baseUrl + "/";

        public HomePage(IWebDriver driver) : base(driver, Url)
        {
            
        }
    }
}
