using OpenQA.Selenium;

namespace CaseStudy.Pages
{
    class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Giriş Yap"));

        //IWebElement logOff => Driver.FindElement(By.XPath(".//*[@id='header__container']/div/div[2]/div/div[3]/div[2]/div/div/div/ul/li[@class='welcome-class']"));

        public void ClickLogin() => lnkLogin.Click();
        //public bool isLogOffExist() => logOff.Displayed;

    }
}
