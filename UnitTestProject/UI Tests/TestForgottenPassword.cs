using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Hadoken.UI_Tests
{
    [TestFixture]
    public class TestForgottenPassword 
        //: TestBase
    { 
   IWebDriver driver = new ChromeDriver();
        
    
        [SetUp]

        public void Setup()
        {
            driver.Navigate().GoToUrl("https://www.easyjet.com/EN/secure/AccountManagement.mvc/PasswordReset");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test06()
        {
            //Test to check Email address field is displayed
            var EmailAddress = driver.FindElement(By.Name("EmailAddress"));

            Assert.AreEqual(EmailAddress, EmailAddress);
        }

        [Test]
        public void Test07()
        {
            //Test to check Confirm email address field is displayed
            var ConfirmEmailAddress = driver.FindElement(By.Id("confirmEmailAddress"));

            Assert.AreEqual(ConfirmEmailAddress, ConfirmEmailAddress);
        }

        [Test]
        public void Test08()
        {
            //Confirm Cancel button is displayed
            var btnCancel = driver.FindElement(By.Id("btnCancel"));

            Assert.AreEqual(btnCancel, btnCancel);
            
        }

        [Test]
        public void Test09()
        {
            //Test to check Confirm button is displayed
            var btnSend = driver.FindElement(By.Id("btnSend"));

            Assert.AreEqual("Confirm", btnSend.Text);
            Assert.That(btnSend.Displayed, Is.True);

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }



}
