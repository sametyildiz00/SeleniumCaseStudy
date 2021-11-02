using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Pages
{
    class LoginPage : DriverHelper
    {
        IWebElement txtUserName => Driver.FindElement(By.Id("LoginEmail"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.Id("loginLink"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
