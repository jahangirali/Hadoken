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
        public void Test01CheckEmailAddressFieldIsDisplayed()
        {
            var EmailAddress = driver.FindElement(By.Name("EmailAddress"));

            Assert.AreEqual(EmailAddress, EmailAddress);
        }

        [Test]
        public void Test02CheckConfirmEmailAddressIsDisplayed()
        {
            var ConfirmEmailAddress = driver.FindElement(By.Id("confirmEmailAddress"));

            Assert.AreEqual(ConfirmEmailAddress, ConfirmEmailAddress);
        }

        [Test]
        public void Test03CancelButtonIsDisplayed()
        {
            var btnCancel = driver.FindElement(By.Id("btnCancel"));

            Assert.AreEqual(btnCancel, btnCancel);
            
        }

        [Test]
        public void Test04CheckConfirmButtonIsDisplayed()
        {
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
