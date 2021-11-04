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
    public class AddEmployeeSteps
    {
        AddEmployeePages addemployeepages;

        public AddEmployeeSteps()
        {
            addemployeepages = new AddEmployeePages();
        }

        [Given(@"I Navigate To https://opensource-demo\.orangehrmlive\.com/")]
        public void GivenINavigateToHttpsOpensource_Demo_Orangehrmlive_Com()
        {
            addemployeepages.NavigateToWebsite();
        }
        [Given(@"I Enter Admin Username")]
        public void GivenIEnterAdminUsername()
        {
            addemployeepages.EnterAdminUsername();
        }

        [Given(@"I Enter Admin Password")]
        public void GivenIEnterAdminPassword()
        {
            addemployeepages.EnterAdminPassword();
        }
        [Given(@"I Click Login")]
        public void GivenIClickLogin()
        {
            addemployeepages.ClickLogin();
        }

        [Given(@"I Click on PIM")]
        public void GivenIClickOnPIM()
        {
            addemployeepages.ClickonPIM();
        }

        [Given(@"I Click on Add Employee")]
        public void GivenIClickOnAddEmployee()
        {
            addemployeepages.ClickOnAddEmployee();
        }

        [Given(@"I Enter Firstname")]
        public void GivenIEnterFirstname()
        {
            addemployeepages.Firstname();
        }

        [Given(@"I Enter Lastname")]
        public void GivenIEnterLastname()
        {
            addemployeepages.LastName();
        }

        [Given(@"I Enter Employee Id number")]
        public void GivenIEnterEmployeeIdnumber()
        {
            addemployeepages.EnterEmployeeIdNumber();
        }

        [Given(@"I Click On Choose file""(.*)""")]
        public void GivenIClickOnChooseFile(string file)
        {
        Thread.Sleep(5000);
        addemployeepages.ClickOnChoosefile(file);
        ScenarioContext.Current["file"] = file;
        }
      


        [Given(@"I Check the box for create login details")]
        public void GivenICheckTheBoxForCreateLoginDetails()
        {
            addemployeepages.ClickOnCreateDetails();
        }
        
        [Given(@"I Enter Username")]
        public void GivenIEnterUsername()
        {
            addemployeepages.EnterUsername();
        }
        
        [Given(@"I Enter Password")]
        public void GivenIEnterPassword()
        {
            addemployeepages.Password();
        }
        
        [Given(@"I Enter confirm Password")]
        public void GivenIEnterConfirmPassword()
        {
            addemployeepages.ConfirmPassword();
        }
        
        [Given(@"I Select Enabled for Status")]
        public void GivenISelectEnabledForStatus()
        {
            addemployeepages.IEnabledStatus();
        }
        [Given(@"I generate a save button click")]
        public void GivenIGenerateASaveButtonClick()
        {
            addemployeepages.ClickOnSaveButton();
        }
        [Given(@"The Click on Edit")]
        public void GivenTheClickOnEdit()
        {
            addemployeepages.ClickEdit();
        }

        [Given(@"I Select Marital Status")]
        public void GivenISelectMaritalStatus()
        {
            addemployeepages.ISelectMaritalStatus();
        }

        [Given(@"User select Date of birth")]
        public void GivenUserSelectDateOfBirth()
        {
            Thread.Sleep(5000);
            addemployeepages.UserSelectDateOfBirth();
        }

        [Given(@"I click Gender")]
        public void GivenIClickGender()
        {
            addemployeepages.ClickGender();
        }
       
        [Given(@"I Select Nationality")]
        public void GivenISelectNationality()
        {
            Thread.Sleep(5000);
            addemployeepages.ISelectNationality();
        }
        [When(@"I generate a save button click")]
        public void WhenIGenerateASaveButtonClick()
        {
            addemployeepages.IClickOnSave();
        }

        [Given(@"I click on contact details")]
        public void GivenIClickOnContactDetails()
        {
            addemployeepages.ClickOnContactDetails();
        }
        [Given(@"User click edit")]
        public void GivenUserClickEdit()
        {
            addemployeepages.TheUserClickEdit();
        }

        
        [Given(@"I Click on Edit Button")]
        public void GivenIClickOneditButton()
        {
            Thread.Sleep(3000);
            addemployeepages.IClickEdit();
        }


        

        [Given(@"I Enter Address")]
        public void GivenIEnterAddress()
        {
            addemployeepages.EnterAddress();
        }
        
        [Given(@"I Enter City")]
        public void GivenIEnterCity()
        {
            addemployeepages.EnterAddress();
        }
        
        [Given(@"I Enter Postcode")]
        public void GivenIEnterPostcode()
        {
            addemployeepages.EnterPostcode();
        }
        
        [Given(@"I Select Country")]
        public void GivenISelectCountry()
        {
            addemployeepages.SelectCountry();
        }

        [Given(@"I Enter Mobile")]
        public void GivenIEnterMobile()
        {
            addemployeepages.EnterMobile();
        }
        [Given(@"The User Click save")]
        public void GivenTheUserClickSave()
        {
            addemployeepages.TheUserClickEdit();
        }


        [Given(@"I Enter other Email")]
        public void GivenIEnterOtherEmail()
        {
            addemployeepages.EnterOtherEmail();
        }
       


        [Given(@"I Click Emergency Contacts")]
        public void GivenIClickEmergencyContacts()
        {
            addemployeepages.ClickOnEmergencyContact();
        }

        [Given(@"I Click on Add")]
        public void GivenIClickOnAdd()
        {
            addemployeepages.ClickOnAdd();
        }
        
        [Given(@"I Enter Name")]
        public void GivenIEnterName()
        {
            addemployeepages.EnterName();
        }
        
        [Given(@"I Enter Relationship")]
        public void GivenIEnterRelationship()
        {
            addemployeepages.EnterRelationship();
        }
        [Given(@"Client Enter Mobile")]
        public void GivenClientEnterMobile()
        {
            addemployeepages.ClientEnterMobile();
        }



        [Given(@"I Click submit save")]
        public void GivenIClickSubmitSave()
        {
            addemployeepages.IClickSubmitSave();
        }



        [Then(@"It will then be verified That The link was added and registered correctly")]
        public void ThenItWillBeVerifiedThatTheLinkWasAddedAndRegisteredCorrectly()
        {

        }
        
        [Given(@"I Click on Immigration")]
        public void GivenIClickOnImmigration()
        {
            addemployeepages.IClickOnImmigration();
        }
        [Given(@"I Click on Add Immigration Records")]
        public void GivenIClickOnAddImmigrationRecords()
        {
            addemployeepages.IclickOnAddImmigrationRecords();
        }

        [Given(@"I click Passport for document")]
        public void GivenIClickPassportForDocument()
        {
            addemployeepages.IClickPassport();
        }

        [Given(@"I Enter Number")]
        public void GivenIEnterNumber()
        {
            addemployeepages.IEnterNumber();
        }

       

        [Given(@"I Select Issued by")]
        public void GivenISelectIssuedBy()
        {
            addemployeepages.SelectIssuedBy();
        }


        [Given(@"I Enter Comment")]
        public void GivenIEnterComment()
        {
            addemployeepages.EnterComment();
        }

        [Given(@"Customer Click on Save Page")]
        public void GivenCustomerClickOnSavePage()
        {
            addemployeepages.ClickSavePage();
        }


        [Then(@"I Can now Confirm information is sufficiently")]
        public void ThenICanNowConfirmedInformationIsSufficiently()
        {
           
        }
        
        [Given(@"I Click on Job")]
        public void GivenIClickOnJob()
        {
            addemployeepages.ClickOnJob();
        }
        
        [Given(@"I Select Job Title")]
        public void GivenISelectJobTitle()
        {
            addemployeepages.SelectJobTitle();
        }
        
        [Given(@"I Select Employment Status")]
        public void GivenISelectEmploymentStatus()
        {
            addemployeepages.SelectEmploymentStatus();
        }
           
        
        [Given(@"I Select Job Category")]
        public void GivenISelectJobCategory()
        {
            addemployeepages.SelectJobCatergory();
        }
        [Given(@"The Edit Button is selected")]
        public void GivenTheEditButtonIsSelected()
        {
            addemployeepages.EditButtonSelected();
        }
        
        [Given(@"I Select Sb-Unit")]
        public void GivenISelectSb_Unit()
        {
            addemployeepages.SelectSbUnit();
        }
        
        [Given(@"I Select Location")]
        public void GivenISelectLocation()
        {
            addemployeepages.SelectLocation();
        }

        [Given(@"User Click choose file""(.*)""")]
        public void GivenUserClickChooseFile(string file)
        {
            Thread.Sleep(5000);
            addemployeepages.UserClickChooseFile(file);
            ScenarioContext.Current["file"] = file;
        }

        [Given(@"I click Page Is save")]
        public void GivenIClickPageIsSave()
        {
            addemployeepages.ClickPageIsSave();
        }

        
        [Given(@"I Click on Salary")]
        public void GivenIClickOnSalary()
        {

            addemployeepages.ClickOnSalary();
        }
        [Given(@"User Click on Add Icon")]
        public void GivenUserClickOnAddIcon()
        {
            addemployeepages.UserClickOnAddIcon();
        }


        [Given(@"I Select Pay Grade")]
        public void GivenISelectPayGrade()
        {
            addemployeepages.SelectPayGrade();
        }
        
        [Given(@"I Enter Salary components")]
        public void GivenIEnterSalaryComponents()
        {
            addemployeepages.EnterSalaryComponents();
        }
        
        [Given(@"I Select Pay Frequency")]
        public void GivenISelectPayFrequency()
        {
            addemployeepages.SelectPayFrequency();
        }
        
        [Given(@"I Select Currency")]
        public void GivenISelectCurrency()
        {
            addemployeepages.SelectCurrency();
        }
        
        [Given(@"I Enter Amount")]
        public void GivenIEnterAmount()
        {
            addemployeepages.EnterAmount();
        }
        
        [Given(@"I Tick add Direct Deposit Details")]
        public void GivenITickAddDirectDepositDetails()
        {
            addemployeepages.DepositDetail();
        }
        
        [Given(@"I Enter Account Number")]
        public void GivenIEnterAccountNumber()
        {
            addemployeepages.EnterAccountNumber();
        }
        
        [Given(@"I Select Account Type")]
        public void GivenISelectAccountType()
        {
            addemployeepages.SelectAccountType();
        }
        
        [Given(@"I Enter Routing Number")]
        public void GivenIEnterRoutingNumber()
        {
            addemployeepages.EnterRoutingNumber();
        }
         
        [Given(@"Input the Amount")]
        public void GivenInputTheAmount()
        {
            addemployeepages.InputTheAmount();
        }

        [Given(@"I Click Confirm save")]
        public void GivenIClickConfirmSave()
        {
            addemployeepages.IClickConfirmSave();
        }

        [Given(@"I Click on Report to")]
        public void GivenIClickOnReportTo()
        {
            addemployeepages.ClickOnReportOn();
        }
        [Given(@"I click add Assigned Supervisor")]
        public void GivenIClickAddAssignedSupervisor()
        {
            addemployeepages.ClickAddAssignedSupervisor();
        }


        [Given(@"I Enter Supervisor name")]
        public void GivenIEnterSupervisorName()
        {
            addemployeepages.EnterSupervisorName();
        }
        [When(@"I Select Direct for Reporting method")]
        public void WhenISelectDirectForReportingMethod()
        {
            addemployeepages.SelectReportingMethod();
        }
        [Then(@"I press the Save click")]
        public void ThenIPressTheSaveClick()
        {
            addemployeepages.PressTheSaveclick();
        }



    }
}
