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
    public class DependantAddPage
    {
        private readonly FileLocations fileLocations;
        public DependantAddPage()
            {
                driver = BaseTest.driver;
            fileLocations = new FileLocations();
        }

            IWebDriver driver;
        private IWebElement selectDay;
        private IWebElement selectYear;
        private IWebElement selectMonth;
        private IWebElement selectRelationship;


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
        IWebElement SaveButton => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement PersonalDetails => driver.FindElement(By.XPath("//*[@id='pdMainContainer']/div[1]/h1"));
        IWebElement Dependants => driver.FindElement(By.XPath("//*[@id='sidenav']/li[4]/a"));
        IWebElement Add => driver.FindElement(By.XPath("//*[@id='btnAddDependent']"));
        IWebElement Name => driver.FindElement(By.XPath("//input[@class='formInputText']"));
        IWebElement Relationship => driver.FindElement(By.XPath("//*[@id='dependent_relationshipType']"));
        IWebElement Calender => driver.FindElement(By.XPath("//*[@id='frmEmpDependent']/fieldset/ol/li[4]/img"));
        IWebElement Month => driver.FindElement(By.XPath("//*[@id='ui-datepicker-div']/div/div/select[1]"));
        IWebElement Year => driver.FindElement(By.XPath("//*[@id='ui-datepicker-div']/div/div/select[2]"));
        IWebElement Day => driver.FindElement(By.XPath("//*[@id='ui-datepicker-div']/table/tbody/tr[4]/td[1]/a"));
       
        IWebElement Save => driver.FindElement(By.XPath("//input[@name='btnSaveDependent']"));
        IWebElement AssignedDependents => driver.FindElement(By.XPath("//*[@id='listing']/div[1]/h1"));




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
        public void IClickSaveButton()
        {
            SaveButton.Click();
        }
        public bool IsPersonalDetailsDisplayed()
        {
            Thread.Sleep(5000);
            return PersonalDetails.Displayed;
        }
        public void IClickdependant()
        {
            Dependants.Click();
        }
        public void IClickAdd()
        {
            Add.Click();
        }
        public void IEnterName()
        {
            Name.SendKeys("Omokunle adebolad");
        }
        public void ISelectRelationship()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(Relationship);
            select.SelectByValue("child");
        }
        public void IClickCalender()
        {
            Calender.Click();
        }
        public void ISelectMonth()
        {
            SelectElement select = new SelectElement(Month);
            select.SelectByValue("2");
        }
        public void ISelectYear()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(Year);
            select.SelectByValue("2001");
        }
        public void ISelectDay()
        {
            Day.SendKeys("19");
        }
        public void IClickSave()
        {
            Save.Click();
        }
        public bool IsAssignedDependentDisplayed()
        {
            Thread.Sleep(5000);
            return AssignedDependents.Displayed;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

















    }
}
