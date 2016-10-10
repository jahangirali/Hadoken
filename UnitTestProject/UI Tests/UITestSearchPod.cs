using System.Runtime.InteropServices;
using Hadoken.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Hadoken.UI_Tests
{
   [TestFixture]

        public class UITestSearchPod

        {
            IWebDriver Driver = new ChromeDriver();

        [SetUp]
            public void Setup()
            {
            Driver.Navigate().GoToUrl("https://fcpqa.tc-nonprod.easyjet.com/us/");
            Driver.Manage().Window.Maximize();
            }

            [Test]

            public void VerifyElementsSearchPod()
            {
            var SearchPodPage = new SearchPod(Driver);
            
            
            Assert.That(SearchPodPage.IsOneWayCheckBoxDisplayed, Is.True, "One Way check box was not displayed");
            Assert.That(SearchPodPage.IsFromFieldDisplayed, Is.True, "Origin field is not displayed");
            Assert.That(SearchPodPage.IsToFieldDisplayed, Is.True, "Destination field not displayed");
            Assert.That(SearchPodPage.IsOutboundCalendarDisplayed, Is.True, "Outbound calendar not displayed");
            Assert.That(SearchPodPage.IsInboundCalendarDisplayed, Is.True, "Inbound calendar not displayed");
            Assert.That(SearchPodPage.GetAdultLabelText(), Is.EqualTo("Adults(16+)"));
            Assert.That(SearchPodPage.GetChildrenLabelText(), Is.EqualTo("Children (2-15)"));
            Assert.That(SearchPodPage.GetInfantLabelText(),Is.EqualTo("Infants (<2)"));
            Assert.That(SearchPodPage.IsShowFlightsDisplayed, Is.True, "Show Flights button not displayed");
            //Missing Special assistance hyperlink
        }



        [Test]
            public void TestOriginAirportWaterMark()
        {
            var OriginAirportFieldWaterMark = Driver.FindElement(By.CssSelector("input[placeholder='e.g. London Gatwick']"));
            Assert.That(OriginAirportFieldWaterMark.Text, Is.EqualTo(""));
        }

            
           
        [OneTimeTearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }

   }


