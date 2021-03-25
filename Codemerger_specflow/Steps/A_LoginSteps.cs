 
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Codemerger_specflow
{
    [Binding]
    public class Login
    {
        [Given(@"go to this url ""(.*)""")]
        public void GivenGoToThisUrl(string url)
        {
            PropertiesCollection.ngdriver = new ChromeDriver();
            // string  Testurl = ConfigurationManager.AppSettings.Get(url);
            //PropertiesCollection.ngdriver.Manage().Window.Maximize();
            PropertiesCollection.ngdriver.Navigate().GoToUrl(url);
            Console.WriteLine("landed on the login page");

        }

        [Given(@"enter username and password")]
        public void GivenEnterUsernameAndPassword()
        {
        }

        [Given(@"I enter as below")]
        public void GivenIEnterAsBelow(Table credentials)
        {
            dynamic Credentials = credentials.CreateDynamicInstance();
            string username = Credentials.username;
            string password = Credentials.password;
            CustomControls.Entertext("#txtLoginId", username, propertytype.CssSelector);
            CustomControls.Entertext("#txtPassword", password, propertytype.CssSelector);

        }



        [Given(@"the user should stay on the same login screen\.")]
        public void GivenTheUserShouldStayOnTheSameLoginScreen_()
        {
            CustomControls.click("#btnLogin", propertytype.CssSelector);
            delayfor.delay();
        }

        [Given(@"the user should land on page titles ""(.*)""")]
        public void GivenTheUserShouldLandOnPageTitles(string dashboard)
        {
            CustomControls.click("#btnLogin", propertytype.CssSelector);
            delayfor.delay();

            Globalelements.Expectedresult = dashboard;
            Globalelements.Actualresult = CustomControlsGets.GettextfromLabel("div[class='col-lg-7'] h2", propertytype.CssSelector);
            Console.WriteLine("The landed page lands on " + Globalelements.Actualresult);
            Assertions.assertionequals(Globalelements.Actualresult, Globalelements.Expectedresult);
        }

    }
}