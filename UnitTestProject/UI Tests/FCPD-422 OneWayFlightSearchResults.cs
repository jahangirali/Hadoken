using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Hadoken.Pages;

namespace Hadoken.UI_Tests
{
    class FCPD_422_OneWayFlightSearchResults
    {
        IWebDriver Driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://fcpqa.tc-nonprod.easyjet.com/us/");
            Driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void Test01()
        {
            Driver.Navigate().GoToUrl("https://fcpqa.tc-nonprod.easyjet.com/us/");
            Driver.Manage().Window.Maximize();

            var SearchPodPage = new SearchPod(Driver);

            SearchPodPage.ClickCheckBox();
            SearchPodPage.EnterTextInFromField("AMS");
            SearchPodPage.EnterTextInToField("LTN");

           Assert.That(SearchPodPage.IsOneWayCheckBoxChecked, Is.False);
            //Assert.That(SearchPodPage.GetFromFieldText, Equals("AMS"));
            
        }

        [Test]
        public void Test02()
        {
            
        }

        //[OneTimeTearDownAttribute]
        //public void TestTearDown()
        //{
        //    Driver.Quit();
        //}
    }
}
