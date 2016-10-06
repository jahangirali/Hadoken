using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Hadoken.Pages
{
    internal class FlightResults
    {
        private IWebDriver Driver { get; set; }

        public FlightResults(IWebDriver driver)
        {
            Driver = driver;
        }

        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://fcpqa.tc-nonprod.easyjet.com/us/");
            Driver.Manage().Window.Maximize();

            var oneWayCheckBox = Driver.FindElement(By.Id("label-one-way"));


        }
    }
}
