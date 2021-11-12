using NUnit.Framework;
using OrangeHRMProjectJune.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class DependantAddSteps
    {

        DependantAddPage dependantAddPage;

            public DependantAddSteps()
            {
            dependantAddPage = new DependantAddPage();
            }



            [Given(@"The user navigate to ""(.*)""")]
        public void GivenTheUserNavigateTo(string p0)
        {
            dependantAddPage.NavigateToWebsite();
        }
        
        [Given(@"The user Enter Admin Username")]
        public void GivenTheUserEnterAdminUsername()
        {
            dependantAddPage.UserEnterAdminUsername();
        }
        
        [Given(@"The user Enter Admin Password")]
        public void GivenTheUserEnterAdminPassword()
        {
            dependantAddPage.UserEnterAdminPassword();
        }
        
        [Given(@"The user Click Login")]
        public void GivenTheUserClickLogin()
        {
            dependantAddPage.UserClickLogin();
        }
        
        [Given(@"The user Click on PIM")]
        public void GivenTheUserClickOnPIM()
        {
            dependantAddPage.UserClickOnPIM();
        }
        
        [Given(@"The User Click on Add Employee")]
        public void GivenTheUserClickOnAddEmployee()
        {
            dependantAddPage.UserClickOnAddEmployee();
        }
        
        [Given(@"The user Enter Firstname")]
        public void GivenTheUserEnterFirstname()
        {
            dependantAddPage.UserEnterFirstname();
        }
        
        [Given(@"The user Enter Lastname")]
        public void GivenTheUserEnterLastname()
        {
            dependantAddPage.UserEnterLastName();
        }
        
        [Given(@"The user Enter Employee Id number")]
        public void GivenTheUserEnterEmployeeIdNumber()
        {
            dependantAddPage.UserEnterEmployeeIdNumber();
        }
        
        [Given(@"The user Click On Choose file""(.*)""")]
        public void GivenTheUserClickOnChooseFile(string file)
        {
            Thread.Sleep(5000);
            dependantAddPage.ClickOnChoosefile(file);
            ScenarioContext.Current["file"] = file;
        }
        
        [Given(@"The user Check the box for create login details")]
        public void GivenTheUserCheckTheBoxForCreateLoginDetails()
        {
            dependantAddPage.UserClickOnCreateDetails();
        }
        
        [Given(@"The user Enter Username")]
        public void GivenTheUserEnterUsername()
        {

            dependantAddPage.UserEnterUsername();
        }
        
        [Given(@"The user Enter Password")]
        public void GivenTheUserEnterPassword()
        {
            dependantAddPage.UserEnterPassword();
        }
        
        [Given(@"The user Enter confirm Password")]
        public void GivenTheUserEnterConfirmPassword()
        {
            dependantAddPage.UserenterConfirmPassword();
        }
        
        [Given(@"The user Click Enabled for Status")]
        public void GivenTheUserClickEnabledForStatus()
        {
            dependantAddPage.UserClickEnabledStatus();
        }
        
        [Given(@"The user generate a save button click")]
        public void GivenTheUserGenerateASaveButtonClick()
        {
            dependantAddPage.IClickSaveButton();
        }
        [Given(@"User land on personal details")]
        public void GivenUserLandOnPersonalDetails()
        {
            Assert.That(dependantAddPage.IsPersonalDetailsDisplayed);
        }


        [Given(@"I Click on Dependents")]
        public void GivenIClickOnDependents()
        {
            Thread.Sleep(3000);
            dependantAddPage.IClickdependant();
        }

        [Given(@"I Click Add")]
        public void GivenIClickAdd()
        {
            dependantAddPage.IClickAdd();
        }

        [Given(@"I User Enter Name")]
        public void GivenIUserEnterName()
        {
            dependantAddPage.IEnterName();
        }

        [Given(@"I Select Relationship")]
        public void GivenISelectRelationship()
        {
            Thread.Sleep(5000);
            dependantAddPage.ISelectRelationship();
        }
        [Given(@"I click on Calender")]
        public void GivenIClickOnCalender()
        {
            dependantAddPage.IClickCalender();
        }

        [Given(@"I Select month")]
        public void GivenISelectMonth()
        {
            dependantAddPage.ISelectMonth();
        }

        [Given(@"I Select year")]
        public void GivenISelectYear()
        {
            dependantAddPage.ISelectYear();
        }

        [Given(@"I select day")]
        public void GivenISelectDay()
        {
            dependantAddPage.ISelectDay();
        }


        [When(@"I Click on Save")]
        public void WhenIClickOnSave()
        {
            dependantAddPage.IClickSave();
        }

        [Then(@"Confirm you have successfully added dependents")]
        public void ThenConfirmYouHaveSuccessfullyAddedDependents()
        {
            Assert.That(dependantAddPage.IsAssignedDependentDisplayed);
        }



    }
}
