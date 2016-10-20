using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Hadoken.UI_Tests
{
    public class TestBase
    {
        public IWebDriver Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.Chrome());

        [OneTimeTearDown]
        public void TestTearDown()
        {
            Driver.Manage().Cookies.DeleteCookieNamed("_easy");
            Driver.Quit();
        }
    }
}
