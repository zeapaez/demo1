using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace unoSquare.POM
{
    class POM_Amazon
    {
        private IWebDriver _driver;

        public POM_Amazon(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement TXT_SearchBar => _driver.FindElement(By.Id("twotabsearchtextbox"));
        public IWebElement BTN_Search => _driver.FindElement(By.Id("nav-search-submit-button"));
        public IWebElement IMG_Row1 => _driver.FindElement(By.XPath("//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div[1]/div/span/div/div/div[2]/div[1]/div/div/span/a/div/img"));

        public IWebElement LNK_Row1 => _driver.FindElement(By.XPath("//*[@data-cel-widget='search_result_0']//*[@class='a-link-normal a-text-normal]"));
     
        public IWebElement LBL_PriceResultsPage => _driver.FindElement(By.XPath("//*[@data-cel-widget='search_result_0']//*[@class='a-price']"));
        public IWebElement LBL_PriceInsideBuy => _driver.FindElement(By.Id("price_inside_buybox"));
        public IWebElement BTN_AddCart => _driver.FindElement(By.Id("add-to-cart-button"));
        public IWebElement BTN_Cart => _driver.FindElement(By.ClassName("nav-cart-icon nav-sprite"));
        public IWebElement LBL_PriceCart => _driver.FindElement(By.XPath("//*[@class='a-row a-spacing-base a-spacing-top-base']//*[@class='a-spacing-small']/span"));
        public IWebElement BTN_ProceedCheckout => _driver.FindElement(By.Name("proceedToRetailCheckout"));
        public IWebElement LNK_DeleteItem => _driver.FindElement(By.ClassName("a-size-small sc-action-delete"));


        public void SearchItem(string value)
        {
            TXT_SearchBar.SendKeys(value);
            BTN_Search.Click();
        }
    }
}

