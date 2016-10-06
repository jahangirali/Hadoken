using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hadoken.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Hadoken.UI_Tests
{
    [TestFixture]
    public class FCPD_13SearchPod_OneWayCheckBox
    {
        IWebDriver Driver = new ChromeDriver();

        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://fcpqa.tc-nonprod.easyjet.com/us");
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test01()
        {
            var SearchPodPage = new SearchPod(Driver);

            Assert.That(SearchPodPage.IsOneWayCheckBoxDisplayed, Is.True, "One Way checkbox is not displayed.");

            
            
        }

        //[Test]
        //public bool Test02()
        //{
        //    var SearchPodPage = new SearchPod(Driver);

        //    SearchPodPage.ClickCheckBox();
        //    Assert.That(SearchPodPage.ClickCheckBox(), Is.False);
            
        //}

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
