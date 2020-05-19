using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Linq;
using OpenQA.Selenium;
using TechTalk.SpecFlow.CucumberMessages;
using Amazon_Automated_Web_Test.ConfigReader;

namespace Amazon_Automated_Web_Test.POM
{
    class SignInPage
    {
        private readonly IWebDriver Driver;
        private readonly string SignInUrl = "https://www.amazon.co.uk/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.co.uk%2F%3Fref_%3Dnav_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=gbflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&";

        public SignInPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(SignInUrl);
        }

        public void EnterEmail(string email) => Driver.FindElement(By.Id("ap_email")).SendKeys(email);
        public void ClickContinue() => Driver.FindElement(By.Id("continue")).Click();
        public void InputPassword(string password) => Driver.FindElement(By.Id("ap_password")).SendKeys(password);
        public void ClickSignIn() => Driver.FindElement(By.Id("signInSubmit")).Click();
    }
}
