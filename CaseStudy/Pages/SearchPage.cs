using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CaseStudy.Pages
{
    class SearchPage : DriverHelper
    {
        IWebElement lnkSearch => Driver.FindElement(By.Id("search_input"));
        IWebElement lnkSearchButton => Driver.FindElement(By.Id("search_input"));
        IWebElement lnkElement => Driver.FindElement(By.Id("pageIndex"));
        IList<IWebElement> getAllProducts => Driver.FindElements(By.XPath("//div[@data-category]"));
        

        public void Search() => lnkSearch.Click();
        public void SearchButton()
        {
            Thread.Sleep(5000);
            lnkSearchButton.SendKeys("pantolon");
            lnkSearchButton.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }

        public void Scroll()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", lnkElement);
            lnkElement.Click();
            Thread.Sleep(5000);
        }

        public void product(int k)
        {
            for (int i = 0; i < getAllProducts.Count; i++)
            {
                getAllProducts[i].ToString();
            }
            getAllProducts[k].Click();
        }
    }
}
