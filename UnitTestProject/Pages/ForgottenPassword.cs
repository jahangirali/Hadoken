using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Hadoken.Pages
{
    public class ForgottenPassword
    {
        [FindsBy(How = How.Id, Using = "emailAddress")]
        public IWebElement EmailAddress;

        [FindsBy(How = How.Name, Using = "ConfirmationEmailAddress")]
        public IWebElement ConfirmationEmailAddress;

    }
}
