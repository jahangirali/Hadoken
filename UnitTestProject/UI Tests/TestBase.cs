using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Hadoken.UI_Tests
{
    public class TestBase
    {
        public IWebDriver Driver = new ChromeDriver();

    }
}
