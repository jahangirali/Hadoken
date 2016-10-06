using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Hadoken.User_Journeys
{
    class OneWayFlight
    {
        [TestFixture]

        public class OneWayFlight1

        {
            IWebDriver driver = new ChromeDriver();

            [SetUp]
            public void Setup()
            {

                driver.Navigate().GoToUrl("https://fcpqa.tc-nonprod.easyjet.com/us/");
                driver.Manage().Window.Maximize();
            }

            //[Test]
            //public void OneWayFlight()
            //{

            //}
        }
    }
}
