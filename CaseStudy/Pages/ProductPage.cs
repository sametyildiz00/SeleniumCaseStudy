using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Pages
{
    class ProductPage : DriverHelper
    {
        IWebElement lnkSelect => Driver.FindElement(By.XPath(".//*[@id='option-size']/a"));
        IWebElement lnkAddCart => Driver.FindElement(By.XPath(".//*[@id='pd_add_to_cart']"));
        IWebElement lnkCart2 => Driver.FindElement(By.Id("spanCart"));

        IWebElement PriceArea => Driver.FindElement(By.XPath(".//*[@class='col-xs-12 price-area']"));

        public void ClickCart() => lnkCart2.Click();
        public void ClickSelect() => lnkSelect.Click();
        public void AddCart() => lnkAddCart.Click();

        public string productPrice()
        {
            IList<IWebElement> b = PriceArea.FindElements(By.ClassName("price-regular"));

            if (b.Count > 0)
            {
                IWebElement lnkProductPriceRegular = Driver.FindElement(By.ClassName("price-regular"));
                Console.WriteLine(lnkProductPriceRegular.GetAttribute("innerText"));
                return lnkProductPriceRegular.GetAttribute("innerText");
            }
            else
            {
                IWebElement lnkProductPrice = Driver.FindElement(By.ClassName("price"));
                Console.WriteLine(lnkProductPrice.GetAttribute("innerText"));
                
                return lnkProductPrice.GetAttribute("innerText");
            }
        }
        

        
    }
}