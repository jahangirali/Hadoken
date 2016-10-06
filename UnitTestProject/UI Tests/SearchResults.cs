using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Hadoken.UI_Tests
{
    class SearchResults
    {
        IWebDriver Driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://fcpqa.tc-nonprod.easyjet.com/us/");
            Driver.Manage().Window.Maximize();


            
        }
    }
   
}
