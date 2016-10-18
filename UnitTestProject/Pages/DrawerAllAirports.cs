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
        private IWebElement allAirportsButton()
        {
            return Driver.FindElement(By.Id("all-airports-button"));
        }

        //private IWebElement OutboundCalendar()
        //{
        //    return Driver.FindElement(By.Id("outbound-calendar-image"));
        //}


        //internal bool IsOutboundCalendarDisplayed()
        //{
        //    return OutboundCalendar().Displayed;
        //}


        /// ACTIONS
        internal bool IsAllAirportsDisplayed()
        {
            return allAirportsButton().Displayed;
        }

        internal void ClickAllAirportsButton()
        {
            allAirportsButton().Click();
        }
        
    }
}
