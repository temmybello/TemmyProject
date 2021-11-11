using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.Hooks;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OrangeHRMProjectJune.PageObject
{
    class AddDependentsPage
    {
        class AddEmployeePages
        {
            private readonly FileLocations fileLocations;
            public AddEmployeePages()
            {
                driver = BaseTest.driver;
                fileLocations = new FileLocations();
            }

            IWebDriver driver;

            IWebElement AdminUsername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
            IWebElement AdminPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
            IWebElement Login => driver.FindElement(By.XPath("//*[@id='btnLogin']"));
            IWebElement PIM => driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']/b"));
            IWebElement AddEmployee => driver.FindElement(By.CssSelector("#menu_pim_addEmployee"));
            IWebElement EnterFirstname => driver.FindElement(By.CssSelector("#firstName"));
            IWebElement EnterLastname => driver.FindElement(By.CssSelector("#lastName"));
            IWebElement EmployeeIdNumber => driver.FindElement(By.CssSelector("#employeeId"));
            IWebElement ChooseFile => driver.FindElement(By.CssSelector("#photofile"));
            IWebElement CreateDetails => driver.FindElement(By.XPath("//*[@id='chkLogin']"));
            IWebElement UserName => driver.FindElement(By.CssSelector("#user_name"));
            IWebElement EnterPassword => driver.FindElement(By.CssSelector("#user_password"));
            IWebElement EnterConfirmPassword => driver.FindElement(By.CssSelector("#re_password"));
            IWebElement EnabledStatus => driver.FindElement(By.CssSelector("#status"));



            public void UserEnterAdminUsername()
            {
                AdminUsername.SendKeys("Admin");
            }

            public void UserEnterAdminPassword()
            {
                AdminPassword.SendKeys("admin123");
            }
            public void UserClickLogin()
            {
                Login.Click();
            }
            public void UserClickOnPIM()
            {
                PIM.Click();
            }
            public void UserClickOnAddEmployee()
            {
                AddEmployee.Click();
            }

            public void UserEnterFirstname()
            {
                EnterFirstname.SendKeys("Psakmh");
            }
            public void UserEnterLastName()
            {
                EnterLastname.SendKeys("Jognson");
            }

            public void UserEnterEmployeeIdNumber()
            {
                EmployeeIdNumber.SendKeys("2034");
            }
            public void ClickOnChoosefile(string fileImage)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)BaseTest.driver;
                js.ExecuteScript("window.scrollBy(0, 1500)");
                string imageFolder = fileLocations.GetFolderLocation("TestDataImages");
                ChooseFile.SendKeys(imageFolder + fileImage);
            }
            public void UserClickOnCreateDetails()
            {
                CreateDetails.Click();
            }
            public void UserEnterUsername()
            {
                UserName.SendKeys("Amakea222");
            }
            public void UserEnterPassword()
            {
                EnterPassword.SendKeys("Majekome2233");
            }
            public void UserenterConfirmPassword()
            {
                EnterConfirmPassword.SendKeys("Majekome2233");
            }
            public void UserClickEnabledStatus()
            {
                EnabledStatus.Click();
            }
            public void NavigateToWebsite()
            {
                driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            }







        }

    }   }







