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
        IWebElement Next => driver.FindElement(By.Id("next-button"));
        IWebElement FirstName => driver.FindElement(By.CssSelector("input[id='firstName']"));
        IWebElement LastName => driver.FindElement(By.XPath("//input[@name='lastName']"));
        IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#phoneNumber"));
        IWebElement emailAddress => driver.FindElement(By.CssSelector("#email"));
        IWebElement ByPhone => driver.FindElement(By.CssSelector("#contactConsentPhone"));
        IWebElement ByEmail2 => driver.FindElement(By.CssSelector("#contactConsentEmail"));
        IWebElement Email3 => driver.FindElement(By.CssSelector("#marketingConsent"));
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

        public void IClickNextButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            // Actions actions = new Actions(driver);
            //actions.MoveToElement(Next);
            //actions.Perform();
            //actions.Click();
            Thread.Sleep(5000);
            Next.Click();
            Next.Click();
        }
        public void EnterFirstName(string Name)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(FirstName);
            //actions.Perform();
            FirstName.SendKeys(Name);
        }
        public void EnterLastName(string Name)
        {
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
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            ByPhone.Click();
        }

        public void ClickByEmail2()
        {
            ByEmail2.Click();
        }
        public void IClickEmail3()
        {
            Email3.Click();
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
