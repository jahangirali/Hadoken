using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Hadoken.UI_Tests
{
    [TestFixture]
    public class TestForgottenPassword : TestBase
    { 
 
        
    
        [SetUp]

        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://www.easyjet.com/EN/secure/AccountManagement.mvc/PasswordReset");
            Driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test01CheckEmailAddressFieldIsDisplayed()
        {
            var EmailAddress = Driver.FindElement(By.Name("EmailAddress"));

            Assert.AreEqual(EmailAddress, EmailAddress);
        }

        [Test]
        public void Test02CheckConfirmEmailAddressIsDisplayed()
        {
            var ConfirmEmailAddress = Driver.FindElement(By.Id("confirmEmailAddress"));

            Assert.AreEqual(ConfirmEmailAddress, ConfirmEmailAddress);
        }

        [Test]
        public void Test03CancelButtonIsDisplayed()
        {
            var btnCancel = Driver.FindElement(By.Id("btnCancel"));

            Assert.AreEqual(btnCancel, btnCancel);
            
        }

        [Test]
        public void Test04CheckConfirmButtonIsDisplayed()
        {
            var btnSend = Driver.FindElement(By.Id("btnSend"));

            Assert.AreEqual("Confirm", btnSend.Text);
            Assert.That(btnSend.Displayed, Is.True);

        }

       

    }



}
