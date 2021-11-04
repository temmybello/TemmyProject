using PodCheckout.PageObject;
using System;
using TechTalk.SpecFlow;
using System.Threading;


namespace PodCheckout.StepDefinition
{
    [Binding]
    public class OrderFormSteps
    {
        OrderFormCheckoutPage orderformcheckoutpage;
        public OrderFormSteps()
        {
            orderformcheckoutpage = new OrderFormCheckoutPage();
        }

        [Given(@"I Navigate to the form ""(.*)""")]
        public void GivenINavigateToTheForm(string url)
        {
          orderformcheckoutpage.NavigateToForm(url);
        }

        [Given(@"I need to select Make")]
        public void GivenINeedToSelectMake()
        {
            orderformcheckoutpage.ISelectMake();
        }

        [Given(@"I need to select model")]
        public void GivenINeedToSelectModel()
        {
            orderformcheckoutpage.ISelectMode();
        }

        [Given(@"I click New Car")]
        public void GivenIClickNewCar()
        {
            orderformcheckoutpage.IClickNewCar();
        }

        [Given(@"I click Universal Charger")]
        public void GivenIClickUniversalCharger()
        {
            Thread.Sleep(5000);
            orderformcheckoutpage.IClickUnvisalCharger();
        }

        [Given(@"I click Charges a Bmw(.*)e")]
        public void GivenIClickChargesABmwe(string bmw330e)
        {
            Thread.Sleep(5000);
            orderformcheckoutpage.IClickOnChargesABmw330e();
        }

        [Given(@"I select Extended warranty")]
        public void GivenISelectExtendedWarranty()
        {
            Thread.Sleep(3000);
            orderformcheckoutpage.IClickExtendedWarranty();
        }
        [Given(@"I click Cable Bag")]
        public void GivenIClickCableBag()
        {
            Thread.Sleep(3000);
            orderformcheckoutpage.IClickCableBag();
        }


        [Given(@"I click on next button")]
        public void GivenIClickOnNextButton()
        {
            Thread.Sleep(5000);
            orderformcheckoutpage.IClickNextButton();
            Thread.Sleep(5000);
        }

        [Given(@"Enter my FirstName ""(.*)""")]
        public void GivenEnterMyFirstName(string FirstName)
        {
            orderformcheckoutpage.EnterFirstName(FirstName);
        }


        [Given(@"I enter LastName ""(.*)""")]
        public void GivenIEnterLastName(string LastName)
        {
            Thread.Sleep(3000);
            orderformcheckoutpage.EnterLastName(LastName);
        }

        [Given(@"I enter Phone Number ""(.*)""")]
        public void GivenIEnterPhoneNumber(String Number)
        {
            Thread.Sleep(3000);
            orderformcheckoutpage.EnterPhoneNumber(Number);
        }

        [Given(@"I Enter Email address ""(.*)""")]
        public void GivenIEnterEmailAddress(string Email)
        {
            orderformcheckoutpage.IEnterEmailAddress(Email);
        }

        [Given(@"I click dont Contact me by phone")]
        public void GivenIClickDontContactMeByPhone()
        {
            Thread.Sleep(3000);
            orderformcheckoutpage.IClickByPhone();
        }
        [Given(@"Don't contact me by Email")]
        public void GivenDonTContactMeByEmail()
        {
            orderformcheckoutpage.ClickByEmail2();
        }

        [Given(@"User click I'd prefer not to recieve update")]
        public void GivenUserClickIDPreferNotToRecieveUpdate()
        {
            orderformcheckoutpage.IClickEmail3();
        }
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            orderformcheckoutpage.IClickSubmit1();
        }

        [Then(@"I should be able to submit my details for installation")]
        public void ThenIShouldBeAbleToSubmitMyDetailsForInstallation()
        {
            ScenarioContext.Current.Pending();
        }




    }
}
