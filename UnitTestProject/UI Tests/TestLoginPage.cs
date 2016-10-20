using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;


namespace Hadoken.UI_Tests
{
    [TestFixture]
    public class TestLogin : TestBase
    {
        [SetUp]

        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://www.easyjet.com/mylogin/en-GB/LogOn?ReturnUrl=%2fmylogin%2fen-GB%3fwa%3dwsignin1.0%26wtrealm%3durn%253a%252fmanagebookings%26wctx%3drm%253d0%2526id%253dpassive%2526ru%253d%25252fmanagebookings%25252fen-GB%26wct%3d2016-09-19T13%253a32%253a57Z%26wauth%3durn%253aeasyjet.com%253amember");
            Driver.Manage().Window.Maximize();

        }
        [Test]
        public void Test01VerifyElementsOnLoginPage()
        {
            //Elements displayed
            var radioButtonYes = Driver.FindElement(By.Id("member-login"));
            var radioButtonNo = Driver.FindElement(By.Id("passenger-login"));
            var didYouMakeTheBooking = Driver.FindElement(By.XPath(".//*[@id='signInBox']/legend/button"));
            var emailAddress = Driver.FindElement(By.Id("emailaddress"));
            var passwordField = Driver.FindElement(By.Id("password"));
            var forgotPasswordLink = Driver.FindElement(By.XPath("//a[contains(text(),'I have forgotten my password')]"));
            var bookingReference = Driver.FindElement(By.Id("memberbookingreference"));
            var registerBtn = Driver.FindElement(By.Id("register-button"));
            var signInBtn = Driver.FindElement(By.Id("sign-in-button"));

            //Assert
            Assert.That(radioButtonYes.Enabled, Is.True);
            Assert.That(radioButtonNo.Selected, Is.False);
            Assert.That(didYouMakeTheBooking.Displayed, Is.True);
            Assert.That(emailAddress.Displayed, Is.True);
            Assert.That(passwordField.Displayed, Is.True);
            Assert.That(forgotPasswordLink.Enabled, Is.True);
            Assert.That(bookingReference.Displayed, Is.True);
            Assert.That(registerBtn.Displayed, Is.True);
            Assert.That(signInBtn.Displayed, Is.True);

        }
        
        [Test]
        public void Test02AbleToSignIn()
        {
            var emailAddress = Driver.FindElement(By.Id("emailaddress"));
            var passwordField = Driver.FindElement(By.Id("password"));
            var signInBtn = Driver.FindElement(By.Id("sign-in-button"));
           // var myBookingsLink = driver.FindElement(By.Id("YourBookingsLinkBreadcrumb"));

            emailAddress.SendKeys("jahangir.ali@easyjet.com");
            passwordField.SendKeys("password123");
            
            Assert.That(signInBtn.Displayed, Is.True);
            signInBtn.Click();
            //  Is.EqualTo("Email address *"));

        }

       
    }
}
