using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using Amazon_Automated_Web_Test.POM;
using System.Threading;
using Amazon_Automated_Web_Test.ConfigReader;

namespace Amazon_Automated_Web_Test.Tests
{
    public class TestsExe
    {
     

        [Trait("Category","Smoke")]
        [Fact]
        public void LoadSignInPage()
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                var signInPage = new SignInPage(driver);
                signInPage.NavigateTo();
                Thread.Sleep(3000);
                signInPage.EnterEmail("Tester.Rashiid@gmail.com");
                signInPage.ClickContinue();
                Thread.Sleep(3000);
                signInPage.InputPassword(AppConfigReader.Password);
                Thread.Sleep(3000);
                signInPage.ClickSignIn();
                Thread.Sleep(3000);
            }
        }
    }
}
