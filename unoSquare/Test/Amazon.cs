using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using unoSquare.POM;
using unoSquare.Selenium;

namespace unoSquare
{
    public class Tests
    {
       
        [SetUp]
        public void Setup()
        {
            
            PropertiesCollection.Driver = new ChromeDriver();
            PropertiesCollection.Driver.Manage().Window.Maximize();
            PropertiesCollection.Driver.Navigate().GoToUrl("https://www.amazon.com");
            string aux = ConfigurationManager.AppSettings["Url"];
        }

        [TearDown]
        public void TearDown()
        {
            PropertiesCollection.Driver.Close();
            PropertiesCollection.Driver.Quit();
        }


         [Test]
        public void VerifyPrice1()
        {
           
            POM_Amazon amazon = new POM_Amazon(PropertiesCollection.Driver);
            amazon.SearchItem("Samsung Galaxy Note 20");
            string price1 = amazon.LBL_PriceResultsPage.GetAttribute("innerText");
            amazon.LNK_Row1.Click();
            string price2 = amazon.LBL_PriceInsideBuy.GetAttribute("innerText");
            Assert.AreEqual(price1, price2, "The values are equal");
            amazon.BTN_AddCart.Click();
            amazon.BTN_Cart.Click();
            string price3 = amazon.LBL_PriceCart.GetAttribute("innerText");
            Assert.AreEqual(price2, price3, "The values are equal");
            amazon.BTN_ProceedCheckout.Click();
            PropertiesCollection.Driver.Navigate().Back();
            amazon.LNK_DeleteItem.Click();
            amazon.LNK_DeleteItem.Click();
        }
        [Test]
        public void VerifyPrice2()
        {

            POM_Amazon amazon = new POM_Amazon(PropertiesCollection.Driver);
            amazon.SearchItem("Galaxy S20 FE 5G");
            string price1 = amazon.LBL_PriceResultsPage.GetAttribute("innerText");
            amazon.IMG_Row1.Click();
            string price2 = amazon.LBL_PriceInsideBuy.GetAttribute("innerText");
            Assert.AreEqual(price1, price2, "The values are equal");
            amazon.BTN_AddCart.Click();
            amazon.BTN_Cart.Click();
            string price3 = amazon.LBL_PriceCart.GetAttribute("innerText");
            Assert.AreEqual(price2, price3, "The values are equal");
            amazon.BTN_ProceedCheckout.Click();
            PropertiesCollection.Driver.Navigate().Back();
            amazon.LNK_DeleteItem.Click();
        }
    }
}