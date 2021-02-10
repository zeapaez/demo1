using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace unoSquare.Selenium
{
    public class GenericFunctions
    {
        public static void SelecRowtByIndex(IWebElement we, int index)
        {
            SelectElement selectedValue = new SelectElement(we);
            selectedValue.SelectByIndex(index);

        }

        public static void WaitElementExplicit(IWebElement we)
        {
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.Driver, TimeSpan.FromSeconds(10));
            IWebElement firstResult = wait.Until(e => we);
            Console.WriteLine(firstResult.Text);
            
        }

        public static void WaitElementImplicit(IWebElement we)
        {
            PropertiesCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement dynamicElement = we;
        }


        public static void WaitElementToContinue(IWebElement we)
        {
            var wait = new WebDriverWait(PropertiesCollection.Driver, TimeSpan.FromSeconds(240));
            IWebElement elem = wait.Until(ExpectedConditions.ElementToBeClickable(we));
        }
    }
}

