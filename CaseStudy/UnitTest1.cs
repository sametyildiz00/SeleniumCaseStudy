using CaseStudy.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace CaseStudy
{
    public class Tests : DriverHelper
    {
        Random rnd = new Random();

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void LoginTest()
        {
            //Open the test site and maximaze window
            Driver.Navigate().GoToUrl("https://www.lcwaikiki.com/tr-TR/TR/");
            Driver.Manage().Window.Maximize();
            string url = Driver.Url;

            //Test the main page
            Assert.That(url, Is.EqualTo("https://www.lcwaikiki.com/tr-TR/TR/"), "Anasayfada deðilsiniz!");


            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();
            SearchPage searchPage = new SearchPage();
            ProductPage productPage = new ProductPage();
            BasketPage basketPage = new BasketPage();


            //Go to login page
            homePage.ClickLogin();
            Thread.Sleep(5000);

            //Login after entering e-mail and password
            loginPage.EnterUserNameAndPassword("sametyildiz95@gmail.com", "Sam123456");
            loginPage.ClickLogin();
            //Assert.That(homePage.isLogOffExist(), Is.True, "Giriþ baþarýsýz!");


            //Search is made, go to the bottom of the page and click the button
            searchPage.Search();
            searchPage.SearchButton();
            searchPage.Scroll();
            searchPage.product(rnd.Next(0, 95));

            //Selecet size of product and add to shopping cart then go to BasketPage
            productPage.ClickSelect();
            productPage.AddCart();
            string priceTemp = productPage.productPrice();
            Thread.Sleep(5000);
            productPage.ClickCart();
            Thread.Sleep(5000);
            Assert.That(Equals(basketPage.basketPrice(), priceTemp), Is.True, "Fiyat indirimli!");


            //Increase the number of products and delete the product from the cart
            basketPage.ClickAdd();
            Thread.Sleep(5000);
            basketPage.ClickDelete();
            Assert.That(Equals(basketPage.valueExists(), "2"), Is.True, "Ürün sayýsý yanlýþ!");
            Thread.Sleep(5000);
            Assert.That(basketPage.isBasketEmpty(), Is.True, "Sepet Dolu!");


            log.Info("Understanding logging framework");
            log.Warn("Warning");

        }

    }
}