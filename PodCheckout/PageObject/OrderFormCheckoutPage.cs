using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PodCheckout.PageObject
{
    class OrderFormCheckoutPage
    {
        public OrderFormCheckoutPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement SelectMake => driver.FindElement(By.XPath("//*[@id='vehicleBrand']"));
        IWebElement SelectMode => driver.FindElement(By.XPath("//*[@id='vehicleId']"));
        IWebElement ClickNew => driver.FindElement(By.XPath("//*[@id='carMakeAndModel']/div/div/div[1]/div[3]/label[2]/span"));
        IWebElement UniversalCharger => driver.FindElement(By.XPath("//*[@id='podVariant']/div/div/div/div[1]"));
        IWebElement ChargesABmw330e => driver.FindElement(By.XPath("//*[@id='podModel']/div/div/div[1]/div/label"));
        IWebElement ExtendedWarranty => driver.FindElement(By.XPath("//*[@id='optionalExtras']/div/div/div/div[3]/div/label/h4"));
        IWebElement CableBag => driver.FindElement(By.XPath("//*[@id='optionalExtras']/div/div/div/div[4]"));
        IWebElement Next => driver.FindElement(By.XPath("//*[@id='next-button']"));
        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='firstName']"));
        IWebElement LastName => driver.FindElement(By.XPath("//input[@name='lastName']"));
        IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#phoneNumber"));
        IWebElement emailAddress => driver.FindElement(By.CssSelector("#email"));
        IWebElement ByPhone => driver.FindElement(By.XPath("//Input[@name='consent.phone']"));
        IWebElement ByEmail => driver.FindElement(By.XPath("//input[@name='consent.email']"));
        IWebElement Consentmarketing => driver.FindElement(By.XPath("//*[@name='consent.marketing']"));
        IWebElement Submit1 => driver.FindElement(By.CssSelector("#customerDetail > div > div.max-width-text.m-centre > div > div:nth-child(6) > div > button"));

        public void ISelectMake()
        {
            SelectElement Select = new SelectElement(SelectMake);
            Select.SelectByText("BMW");
        }

        public void ISelectMode()
        {
            SelectElement select = new SelectElement(SelectMode);
            select.SelectByText("330e");
        }
        public void IClickNewCar()
        {
            ClickNew.Click();
        }
        public void IClickUnvisalCharger()
        {
            UniversalCharger.Click();
        }
        public void IClickOnChargesABmw330e()
        {
            ChargesABmw330e.Click();
        }

        public void IClickExtendedWarranty()
        {
            ExtendedWarranty.Click();
        }
        public void IClickCableBag()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            CableBag.Click();
        }

        public void IClickNextOnButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            // Actions actions = new Actions(driver);
            //actions.MoveToElement(Next);
            //actions.Perform();
            //actions.Click();
            Thread.Sleep(5000);
            Next.Click();
        }
        public void EnterFirstName(string Name)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(FirstName);
            //actions.Perform();
            Thread.Sleep(5000);
            FirstName.SendKeys(Name);
        }
        public void EnterLastName(string Name)
        {
            Thread.Sleep(5000);
            LastName.SendKeys(Name);
        }

        public void EnterPhoneNumber(String Number)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            PhoneNumber.SendKeys(Number);
        }
        public void IEnterEmailAddress(String Email)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            emailAddress.SendKeys(Email);
        }
        public void IClickByPhone()
        {
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollBy(0,350)", "");
            Thread.Sleep(3000);
            ByPhone.Click();
        }

        public void ClickByEmail()
        {
            ByEmail.Click();
        }
        public void IClickConsentMarketing()
        {
            Consentmarketing.Click();
        }
        public void IClickSubmit1()
        {
            Submit1.Click();
        }


        public void NavigateToForm(String url)
        {
            driver.Navigate().GoToUrl(url);
        }












    }
}
