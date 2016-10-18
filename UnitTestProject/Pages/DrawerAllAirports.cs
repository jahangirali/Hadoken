using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Hadoken.Pages
{
    internal class DrawerAllAirports
    {
        private IWebDriver Driver { get; set; }
        public DrawerAllAirports(IWebDriver driver)
        {
            Driver = driver;
        }

        /// ELEMENTS
        private IWebElement AllAirportsButton()
        {
            return Driver.FindElement(By.Id("all-airports-button"));
        }

       
        /// ACTIONS
        public bool IsAllAirportsDisplayed()
        {
            return AllAirportsButton().Displayed;
        }

        internal void ClickAllAirportsButton()
        {
            AllAirportsButton().Click();
        }
        
    }
}
