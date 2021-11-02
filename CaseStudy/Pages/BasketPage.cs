using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CaseStudy.Pages
{
    class BasketPage : DriverHelper
    {

        IWebElement lnkAddProduct => Driver.FindElement(By.XPath(".//*[@id='ShoppingCartContent']/div/div/div[2]/div/div/div/div/div/div/a[2]"));
        IWebElement lnkAddProductCountValue => Driver.FindElement(By.XPath(".//*[@id='ShoppingCartContent']/div/div/div[2]/div/div/div/div/div/div/input"));
        IWebElement lnkDeleteProduct => Driver.FindElement(By.XPath(".//*[@id='ShoppingCartContent']/div/div/div[2]/div/div/div[2]/div/a"));
        IWebElement lnkDeleteProductPopUp => Driver.FindElement(By.XPath(".//*[@id='ShoppingCartContent']/div/div/div[2]/div[2]/div/div/div[3]/div/div/a"));
        IWebElement lnkBasketEmpty => Driver.FindElement(By.XPath(".//*[@class='row cart-empty']"));

        IWebElement productBasketPrice => Driver.FindElement(By.XPath(".//*[@id='ShoppingCartContent']/div/div/div[2]/div/div/div[2]/span[@class='rd-cart-item-price mb-15']"));

        public void ClickAdd() => lnkAddProduct.Click();

        public string valueExists()
        {
            return lnkAddProductCountValue.GetAttribute("value");
        }

        public string basketPrice()
        {
            return productBasketPrice.GetAttribute("innerText");
        }
        public bool isBasketEmpty()
        {
            return lnkBasketEmpty.Displayed;
        }

        public void ClickDelete()
        {
            lnkDeleteProduct.Click();
            Thread.Sleep(5000);
            lnkDeleteProductPopUp.Click();

        }

    }
}

