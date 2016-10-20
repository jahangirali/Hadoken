using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Hadoken.Pages;

namespace Hadoken.UI_Tests
{
    [TestFixture]
    class FCPD19_Select_Destination : TestBase
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://fcpqa.tc-nonprod.easyjet.com/us");
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test01AllAirportsDisplayed()
        {
            var searchPodPage = new SearchPod(Driver);
            var drawerAllAirports = new DrawerAllAirports(Driver);
            searchPodPage.ClickDestinationAirportList();

            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            Assert.That(drawerAllAirports.IsAllAirportsDisplayed, Is.True);
          
          
        }
   

}
    }

