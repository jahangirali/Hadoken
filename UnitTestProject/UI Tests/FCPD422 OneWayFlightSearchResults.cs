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
    class Fcpd422OneWayFlightSearchResults
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

            var searchPodPage = new SearchPod(Driver);

            searchPodPage.ClickCheckBox();
            searchPodPage.EnterTextInFromField("AMS");
            searchPodPage.EnterTextInToField("LTN");
            searchPodPage.ClickInboundCalendarImage();
           Assert.That(searchPodPage.IsOneWayCheckBoxChecked, Is.False);
            //Assert.That(SearchPodPage.GetFromFieldText, Equals("AMS"));
            
        }

        //[Test]
        //public void Test02()
        //{
            
        //}

        //[OneTimeTearDownAttribute]
        //public void TestTearDown()
        //{
        //    Driver.Quit();
        //}
    }
}
