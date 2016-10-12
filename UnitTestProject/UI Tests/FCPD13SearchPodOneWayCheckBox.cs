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
    public class Fcpd13SearchPodOneWayCheckBox
    {
        IWebDriver Driver = new ChromeDriver();

        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://fcpqa.tc-nonprod.easyjet.com/us");
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test01CheckboxIsDisplayed()
        {
            var searchPodPage = new SearchPod(Driver);

            Assert.That(searchPodPage.IsOneWayCheckBoxDisplayed, Is.True, "One Way checkbox is not displayed.");
        }

        [Test]
        public void Test02ClickCheckbox()
        {
            var searchPodPage = new SearchPod(Driver);

            searchPodPage.ClickCheckBox();

            Assert.That(searchPodPage.IsOneWayCheckBoxChecked, Is.True);
        }


        [Test]
        public void Test03ReturningFieldNotDisplayed()
        {
            var searchPodPage = new SearchPod(Driver);
            searchPodPage.ClickCheckBox();
            
            Assert.That(searchPodPage.IsReturnDateFieldDisplayed, Is.False);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
