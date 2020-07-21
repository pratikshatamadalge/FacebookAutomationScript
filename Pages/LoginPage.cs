using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FacebookLoginSel.AccessDataExel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FacebookLoginSel.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailTextbox;
        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement PassTextbox;
        [FindsBy(How = How.XPath, Using = "//*[@id='u_0_b']")]
        public IWebElement LoginButton;

        public string testName { get; private set; }

        public void GoToHomePage(string testName)
        {
            Credentials cred = new Credentials();
            EmailTextbox.SendKeys(cred.email);
            PassTextbox.SendKeys(cred.password);

            //Read data from xls file
            //var userData = ExelDataAccess.GetTestData(testName);
            //EmailTextbox.SendKeys(userData.Username);
            //PassTextbox.SendKeys(userData.Password);
            LoginButton.Click();
            Thread.Sleep(5000);
        }
    }
}