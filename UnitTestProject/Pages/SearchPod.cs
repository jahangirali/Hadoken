using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Constraints;


namespace Hadoken.Pages
{
    internal class SearchPod
    {
        private IWebDriver Driver { get; set; }
        public SearchPod(IWebDriver driver)
        {
            Driver = driver;
         }

        #region OneWayCheckBox
        
       
        private IWebElement OneWayCheckBox()
        {
            return Driver.FindElement(By.Id("label-one-way"));
        }

        internal void ClickCheckBox()
        {
            OneWayCheckBox().Click();
        }

        internal bool IsOneWayCheckBoxDisplayed()
        {
            return OneWayCheckBox().Displayed;
        }

        public bool IsOneWayCheckBoxChecked()
        {
            return OneWayCheckBox().Enabled;
        }
        
        #endregion

        #region OriginField

        private IWebElement OriginField()
        {
            return Driver.FindElement(By.Name("origin"));
        }

        internal bool IsFromFieldDisplayed()
        {
            return OriginField().Displayed;
        }

        #endregion


        #region DestinationField
        private IWebElement DestinationField()
        {
            return Driver.FindElement(By.Name("destination"));
        }

        internal bool IsToFieldDisplayed()
        {
            return DestinationField().Displayed;
        }

        #endregion


        #region MyRegion




        private IWebElement OutboundCalendar()
        {
            return Driver.FindElement(By.Id("outbound-calendar-image"));
        }

        
        internal bool IsOutboundCalendarDisplayed()
        {
            return OutboundCalendar().Displayed;
        }

        internal void ClickOutboundCalendar()
        {
            OutboundCalendar().Click();
        }
        private IWebElement InboundCalendar()
        {
            return Driver.FindElement(By.Id("return-calendar-image"));
        }

        public bool IsInboundCalendarDisplayed()
        {
            return InboundCalendar().Displayed;
        }

        #endregion
        private IWebElement AdultLabel()
        {
            return Driver.FindElement(By.CssSelector("div[id = 'adults-section'] span"));
        }

        public string GetAdultLabelText()
        {
            return AdultLabel().Text;
        }


        private IWebElement ChildrenLabel()
        {
            return Driver.FindElement(By.CssSelector("div[id = 'children-section'] span"));
        }

        public string GetChildrenLabelText()
        {
            return ChildrenLabel().Text;
        }

        private IWebElement InfantLabel()
        {
            return Driver.FindElement(By.CssSelector("div[id = 'infants-section'] span"));
        }

        public string GetInfantLabelText()
        {
            return InfantLabel().Text;
        }

        private IWebElement BtnShowFlights()
        {
            return Driver.FindElement(By.Id("search-submit"));
        }

        public bool IsShowFlightsDisplayed()
        {
            return BtnShowFlights().Displayed;
        }

        

        public void EnterTextInFromField(string originAirportName)
        {
            OriginField().Clear();
            OriginField().SendKeys(originAirportName);
            OriginField().Submit();
        }

        public void EnterTextInToField(string destinationAirportName)
        {
            DestinationField().SendKeys(destinationAirportName);
            DestinationField().Submit();
            DestinationField().SendKeys(Keys.Tab);
        }

        
        public void ClickInboundCalendarImage()
        {
            InboundCalendar().Click();

        }

        public void IsOneWayCheckBoxSelected()
        {
            ClickCheckBox();
            
        }

        #region ReturnDate
       

        private IWebElement ReturnDateField()
        {
            return Driver.FindElement(By.ClassName("return-date-picker"));
        }

        internal bool IsReturnDateFieldDisplayed()
        {
            return ReturnDateField().Displayed;
        }

        #endregion

        #region SpecialAssistance
        private IWebElement SpecialAssistanceHyperlink()
        {
            return Driver.FindElement(By.Id("special-assistance"));
        }

        public bool IsSpecialAssistanceDisplayed()
        {
            return Driver.FindElement(By.Id("special-assistance")).Displayed;
        }

        //public void ClickSpecialAssistance()
        //{
        //    SpecialAssistanceHyperlink().Click();
        //}
        #endregion 

    }

}
