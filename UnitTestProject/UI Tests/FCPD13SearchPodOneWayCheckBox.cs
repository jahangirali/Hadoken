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
            var SearchPodPage = new SearchPod(Driver);

            Assert.That(SearchPodPage.IsOneWayCheckBoxDisplayed, Is.False, "One Way checkbox is not displayed.");
        }

        //[Test]
        //public void Test02ClickCheckbox()
        //{
        //    var SearchPodPage = new SearchPod(Driver);

        //    SearchPodPage.ClickCheckBox();
          
        //    Assert.That(SearchPodPage.IsOneWayCheckBoxChecked, Is.False);
        //}


        [Test]
        public void Test03ReturningFieldNotDisplayed()
        {
            var SearchPodPage = new SearchPod(Driver);
            SearchPodPage.ClickCheckBox();

            Assert.That(SearchPodPage.IsReturnDateFieldDisplayed(), Is.False);
        }

     //[TearDown]
     //   public void TearDown()
     //   {
     //       Driver.Quit();
     //   }
    }
}
