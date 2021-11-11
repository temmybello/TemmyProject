using System;
using TechTalk.SpecFlow;
using OrangeHRM.PageObject;
using System.Threading;
using NUnit.Framework;
using OrangeHRMProjectJune.PageObject;
using OpenQA.Selenium;
namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class AddDependentsteps
    {
        AddDependentsPage adddependentspage;

        public AddDependentsteps()
        {
            adddependentspage = new AddDependentsPage();
        }


        [Given(@"The user Enter Admin Username")]
        public void GivenTheUserEnterAdminUsername()
        {
            
        }
        
        [Given(@"The user Enter Admin Password")]
        public void GivenTheUserEnterAdminPassword()
        {
            
        }
        
        [Given(@"The user Click Login")]
        public void GivenTheUserClickLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Click on PIM")]
        public void GivenTheUserClickOnPIM()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The User Click on Add Employee")]
        public void GivenTheUserClickOnAddEmployee()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Enter Firstname")]
        public void GivenTheUserEnterFirstname()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Enter Lastname")]
        public void GivenTheUserEnterLastname()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Enter Employee Id number")]
        public void GivenTheUserEnterEmployeeIdNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Click On Choose file""(.*)""")]
        public void GivenTheUserClickOnChooseFile(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Check the box for create login details")]
        public void GivenTheUserCheckTheBoxForCreateLoginDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Enter Username")]
        public void GivenTheUserEnterUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Enter Password")]
        public void GivenTheUserEnterPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Enter confirm Password")]
        public void GivenTheUserEnterConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user Click Enabled for Status")]
        public void GivenTheUserClickEnabledForStatus()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user generate a save button click")]
        public void GivenTheUserGenerateASaveButtonClick()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
