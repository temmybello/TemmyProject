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
    class AddEmployeePages
    {
        private readonly FileLocations fileLocations;
        public AddEmployeePages()
        {
            driver = BaseTest.driver;
            fileLocations = new FileLocations();
        }

        IWebDriver driver;
        private IWebElement selectDay;
        private IWebElement selectMarried;
        private IWebElement selectNationality;

        IWebElement AdminUsername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement AdminPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement Login => driver.FindElement(By.XPath("//*[@id='btnLogin']"));
        IWebElement PIM => driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']/b"));
        IWebElement AddEmployee => driver.FindElement(By.CssSelector("#menu_pim_addEmployee"));
        IWebElement EnterFirstname => driver.FindElement(By.CssSelector("#firstName"));
        IWebElement EnterLastname => driver.FindElement(By.CssSelector("#lastName"));
        IWebElement EmployeeIdNumber => driver.FindElement(By.CssSelector("#employeeId"));
        IWebElement ChooseFile  => driver.FindElement(By.CssSelector("#photofile"));
        IWebElement CreateDetails => driver.FindElement(By.XPath("//*[@id='chkLogin']"));
        IWebElement UserName => driver.FindElement(By.CssSelector("#user_name"));
        IWebElement EnterPassword => driver.FindElement(By.CssSelector("#user_password"));
        IWebElement EnterConfirmPassword => driver.FindElement(By.CssSelector("#re_password"));
        IWebElement EnabledStatus => driver.FindElement(By.CssSelector("#status"));
        IWebElement SaveButton => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement Edit => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement DateOfBirth => driver.FindElement(By.XPath("//*[@id='personal_DOB']"));
        IWebElement Gender => driver.FindElement(By.XPath("//*[@id='personal_optGender_2']"));
        IWebElement MaritalStatus => driver.FindElement(By.XPath("//*[@id='personal_cmbMarital']"));
        IWebElement Nationality => driver.FindElement(By.XPath("//*[@id='personal_cmbNation']"));
        IWebElement Save => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement ContactDetails => driver.FindElement(By.XPath("//*[@id='sidenav']/li[2]/a"));
        IWebElement UserClickEdit => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement Address => driver.FindElement(By.CssSelector("#contact_street1"));
        IWebElement City => driver.FindElement(By.CssSelector("#contact_city"));
        IWebElement Postcode => driver.FindElement(By.CssSelector("#contact_emp_zipcode"));
        IWebElement Country => driver.FindElement(By.XPath("//*[@id='contact_country']"));        IWebElement Mobile => driver.FindElement(By.XPath("//*[@id='contact_emp_mobile']"));
        IWebElement OtherEmail => driver.FindElement(By.CssSelector("#contact_emp_oth_email"));
        IWebElement UserClickSave=> driver.FindElement(By.XPath("//*[@id='btnSave']"));
        
        IWebElement Emergency => driver.FindElement(By.XPath("//*[@id='sidenav']/li[3]/a"));
        IWebElement Add => driver.FindElement(By.XPath("//*[@id='btnAddContact']"));
        IWebElement Name => driver.FindElement(By.XPath("//*[@id='emgcontacts_name']"));
        IWebElement Relationship => driver.FindElement(By.XPath("//*[@id='emgcontacts_relationship']"));
        IWebElement ClientMobile => driver.FindElement(By.XPath("//*[@id='emgcontacts_mobilePhone']"));
        IWebElement SubmitSave => driver.FindElement(By.XPath("//*[@id='btnSaveEContact']"));
        IWebElement Immigration => driver.FindElement(By.XPath("//*[@id='sidenav']/li[5]/a"));
        IWebElement AddImmigrationRecords => driver.FindElement(By.XPath("//*[@id='btnAdd']"));
        IWebElement Passport => driver.FindElement(By.XPath("//*[@id='immigration_type_flag_1']"));
        IWebElement Number => driver.FindElement(By.XPath("//*[@id='immigration_number']"));
        IWebElement IssuedBy => driver.FindElement(By.XPath("//*[@id='immigration_country']"));
        IWebElement Comment => driver.FindElement(By.XPath("//*[@id='immigration_comments']"));
        IWebElement SavePage => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement Job => driver.FindElement(By.XPath("//*[@id='sidenav']/li[6]/a"));
        IWebElement EditButton => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement JobTitle => driver.FindElement(By.XPath("//*[@id='job_job_title']"));
        IWebElement EmploymentStatus => driver.FindElement(By.XPath("//*[@id='job_emp_status']"));
        IWebElement JobCategory => driver.FindElement(By.XPath("//*[@id='job_eeo_category']"));
        IWebElement SbUnit => driver.FindElement(By.XPath("//*[@id='job_sub_unit']"));
        IWebElement Location => driver.FindElement(By.XPath("//*[@id='job_location']"));
        IWebElement UserChooseFile => driver.FindElement(By.XPath("//*[@id='job_contract_file']"));
        IWebElement PageSave => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement Salary => driver.FindElement(By.XPath("//*[@id='sidenav']/li[7]/a"));
        IWebElement AddIcon => driver.FindElement(By.XPath("//*[@id='addSalary']"));
        IWebElement PayGrade => driver.FindElement(By.XPath("//*[@id='salary_sal_grd_code']"));
        IWebElement SalaryComponents => driver.FindElement(By.XPath("//*[@id='salary_salary_component']"));
        IWebElement PayFrequency => driver.FindElement(By.XPath("//*[@id='salary_payperiod_code']"));
        IWebElement Currency => driver.FindElement(By.XPath("//*[@id='salary_currency_id']"));
        IWebElement Amount => driver.FindElement(By.XPath("//*[@id='salary_basic_salary']"));
        IWebElement Deposit => driver.FindElement(By.XPath("//*[@id='salary_set_direct_debit']"));
        IWebElement AccountNumber => driver.FindElement(By.XPath("//*[@id='directdeposit_account']"));
        IWebElement AccountType => driver.FindElement(By.XPath("//*[@id='directdeposit_account_type']"));
        IWebElement RoutingNumber => driver.FindElement(By.XPath("//*[@id='directdeposit_routing_num']"));
        IWebElement AmountInput => driver.FindElement(By.XPath("//*[@id='directdeposit_amount']"));
        IWebElement ConfirmSave => driver.FindElement(By.XPath("//*[@id='btnSalarySave']"));
        IWebElement ReportTo => driver.FindElement(By.XPath("//*[@id='sidenav']/li[9]/a"));
        IWebElement AddAssignedSupervisor => driver.FindElement(By.XPath("//*[@id='btnAddSupervisorDetail']"));
        IWebElement SupervisorName => driver.FindElement(By.XPath("//*[@id='reportto_supervisorName_empName']"));
        IWebElement ReportingMethod => driver.FindElement(By.XPath("//*[@id='reportto_reportingMethodType']"));
        IWebElement SaveClick => driver.FindElement(By.XPath("//*[@id='btnSaveReportTo']"));
       

        public object Day { get; private set; }

        public void EnterAdminUsername()
        {
            AdminUsername.SendKeys("Admin");
        }

        public void EnterAdminPassword()
        {
            AdminPassword.SendKeys("admin123");
        }
        public void ClickLogin()
        {
            Login.Click();
        }
        public void ClickonPIM()
        {
            PIM.Click();
        }
        public void ClickOnAddEmployee()
        {
            AddEmployee.Click();
        }
       
        public void Firstname()
        {
            EnterFirstname.SendKeys("Olawale");
        }
        public void LastName()
        {
           EnterLastname.SendKeys("Olabimpe");
        }
       
        public void EnterEmployeeIdNumber()
        {
            EmployeeIdNumber.SendKeys("0642");
        }
        public void ClickOnChoosefile(string fileImage)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)BaseTest.driver;
            js.ExecuteScript("window.scrollBy(0, 1500)");
            string imageFolder = fileLocations.GetFolderLocation("TestDataImages");
            ChooseFile.SendKeys(imageFolder + fileImage);
        }
        public void ClickOnCreateDetails()
        {
            CreateDetails.Click();
        }
        public void EnterUsername()
        {
            UserName.SendKeys("Makani222");
        }
        public void Password ()
        {
            EnterPassword.SendKeys("Victoria2234");
        }
        public void ConfirmPassword()
        {
            EnterConfirmPassword.SendKeys("Victoria2234");
        }
        public void IEnabledStatus()
        {
            EnabledStatus.Click();
        }
        public void ClickOnSaveButton()
        {
            SaveButton.Click();
        }
        public void IClickEdit()
        {
            Edit.Click();
        }
        
        public void UserSelectDateOfBirth()
        {
            DateOfBirth.Click();
        }
        public void ClickEdit()
        {
            Edit.Click();
        }
        public void ClickGender()
        {
            Gender.Click();
        }
        public void ISelectMaritalStatus()
        {
            SelectElement select = new SelectElement(MaritalStatus);
            select.SelectByValue("Married");
        }
        
        public void ISelectNationality()
        {
            SelectElement select = new SelectElement(Nationality);
            select.SelectByValue("2");
        }
        public void IClickOnSave()
        {
            Save.Click();
        }
        public void ClickOnContactDetails()
        {
            ContactDetails.Click();
        }
        public void TheUserClickEdit()
        {
            UserClickEdit.Click();
        }
        public void EnterAddress()
        {
            Address.SendKeys("22JallRoad");
        }
        public void EnterCity()
        {
            City.SendKeys("Leytonstone");
        }
        public void EnterPostcode()
        {
            Postcode.SendKeys("Dw125de");
        }
        public void SelectCountry()
        {
            SelectElement select = new SelectElement(Country);
            select.SelectByValue("AF");
        }
        public void EnterMobile()
        {
            Mobile.SendKeys("0796654213");
        }
        public void EnterOtherEmail()
        {
            OtherEmail.SendKeys("Kings@gmail.com");
        }
        public void TheUserClicksave()
        {
            UserClickSave.Click();
        }
        
        
        public void ClickOnEmergencyContact()
        {
            Emergency.Click();
        }
        public void ClickOnAdd()
        {
            Add.Click();
        }
        public void EnterName()
        {
            Name.SendKeys("Abudul");
        }
        public void EnterRelationship()
        {
            Relationship.SendKeys("Single");
        }
        public void ClientEnterMobile()
        {
            ClientMobile.SendKeys("087654398");
        }
        public void IClickSubmitSave()
        {
            SubmitSave.Click();
        }
        public void IClickOnImmigration()
        {
            Immigration.Click();
        }
        public void IclickOnAddImmigrationRecords()
        {
            AddImmigrationRecords.Click();
        }
        public void IClickPassport()
        {
            Passport.Click();
        }
        public void IEnterNumber()
        {
            Number.SendKeys("A16523fd");
        }
       
        public void SelectIssuedBy()
        {
            SelectElement select = new SelectElement(IssuedBy);
            select.SelectByValue("AW");
        }
        public void EnterComment()
        {
            Comment.SendKeys("Welcome");
        }
        public void ClickSavePage()
        {
            SavePage.Click();
        }
        public void ClickOnJob()
        {
            Job.Click();
        }
        public void EditButtonSelected()
        {
            EditButton.Click();
        }
        public void SelectJobTitle()
        {
            SelectElement select = new SelectElement(JobTitle);
            select.SelectByValue("22");
        }
        public void SelectEmploymentStatus()
        {
            SelectElement select = new SelectElement(EmploymentStatus);
            select.SelectByValue("1");
        }
        public void SelectJobCatergory()
        {
            SelectElement select = new SelectElement(JobCategory);
            select.SelectByValue("9");
        }
      
        public void SelectSbUnit()
        {
            SelectElement select = new SelectElement(SbUnit);
            select.SelectByValue("4");
        }
        public void SelectLocation()
        {
            SelectElement select = new SelectElement(Location);
            select.SelectByValue("3");
        }

        public void UserClickChooseFile(string fileImage)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)BaseTest.driver;
            js.ExecuteScript("window.scrollBy(0, 1500)");
            string imageFolder = fileLocations.GetFolderLocation("TestDataImages");
            UserChooseFile.SendKeys(imageFolder + fileImage);
        }
           public void ClickPageIsSave()
        {
            PageSave.Click();
        }
         public void ClickOnSalary()
        {
            Salary.Click();
        }
   
        public void UserClickOnAddIcon()
        {
            AddIcon.Click();
        }
        public void SelectPayGrade()
        {
            SelectElement select = new SelectElement(PayGrade);
            select.SelectByValue("4");
        }
        public void EnterSalaryComponents()
        {
            SalaryComponents.SendKeys("78789");
        }
        public void SelectPayFrequency()
        {
            SelectElement select = new SelectElement(PayFrequency);
            select.SelectByValue("5");
        }
        public void SelectCurrency()
        {
            SelectElement select = new SelectElement(Currency);
            select.SelectByValue("USD");
        }
        public void EnterAmount()
        {
            Amount.SendKeys("40986");
        }
        public void DepositDetail()
        {
            Deposit.Click();
        }
        public void EnterAccountNumber()
        {
            AccountNumber.SendKeys("765432");
        }
        public void SelectAccountType()
        {
            SelectElement select = new SelectElement(AccountType);
            select.SelectByValue("SAVINGS");
        }
        public void EnterRoutingNumber()
        {
            RoutingNumber.SendKeys("32332");
        }
        public void InputTheAmount()
        {
            AmountInput.SendKeys("8000");
        }
        public void IClickConfirmSave()
        {
            ConfirmSave.Click();
        }

        public void ClickOnReportOn()
        {
            ReportTo.Click();
        }
        public void ClickAddAssignedSupervisor()
        {
            AddAssignedSupervisor.Click();
        }
        public void EnterSupervisorName()
        {
            SupervisorName.SendKeys("Micheal");
        }
        public void SelectReportingMethod()
        {
            SelectElement select = new SelectElement(ReportingMethod);
            select.SelectByValue("2");
        }
        public void PressTheSaveclick()
        {
            SaveClick.Click();
        }
       
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }
    }
}
