using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Codemerger_specflow
{
    [Binding]
    public class Hazard_variabilitySteps
    {
        [Given(@"User should be successfully logged in the application")]
        public void GivenUserShouldBeSuccessfullyLoggedInTheApplication()
        {
            implicitwait.ImplicitWait(20);
           
        }
        
        [Given(@"user clicks underwriter\.")]
        public void GivenUserClicksUnderwriter_()
        {
            CustomControls.click("li[id='ctl00_MenuControl_UnderwritingBoxMenu'] span[class='caret']", propertytype.CssSelector);
        }
        
        [Given(@"user clicks New RFP\.")]
        public void GivenUserClicksNewRFP_()
        {
            CustomControls.click("#ctl00_MenuControl_hlSubmission", propertytype.CssSelector);
           
        }



        [Given(@"user sets data for the Submission screen viz different sections in the application")]
        public void GivenUserSetsDataForTheSubmissionScreenVizDifferentSectionsInTheApplication()
        {

        }
        [Given(@"user fills/picks dates for proposed due date and effective due date")]
        public void GivenUserFillsPicksDatesForProposedDueDateAndEffectiveDueDate(Table dates)
        {
            dynamic Dates = dates.CreateDynamicInstance();
            string due_date = Dates.propsed_due_date.ToString();
            string effective_date = Dates.Effective_date.ToString();
            string[] Separate = due_date.Split(' ');
            string desiredDate = Separate[0];
            //send keys for proposed due date
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx02ecc523-2b8f-4e40-a475-84acb1bc5e02", desiredDate, propertytype.CssSelector);
             Separate = effective_date.Split(' ');
             desiredDate = Separate[0];

            // send keys for proposed effective date
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx2418188d-557b-47f1-b6cb-c16a0a5c7384", desiredDate, propertytype.CssSelector);
            // click on side to disappear the calanders
            CustomControls.click("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxc5ff5bfb-0cc0-42e6-a973-93831cebffdd", propertytype.CssSelector);

        }

        [Given(@"user fills data for Information section as")]
        public void GivenUserFillsDataForInformationSectionAs(Table infosection )
        {
            dynamic Infosection = infosection.CreateDynamicInstance();
            
            
            
            
            // sendkeys for account information

             
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxc5ff5bfb-0cc0-42e6-a973-93831cebffdd", Infosection.Policy_holder_name, propertytype.CssSelector);
            Globalelements.locationinfo = Infosection.Policy_holder_name;
            // sendKeys for DBA
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxf02d21b7-9f28-4330-ac9b-2a2d1be52afb", Infosection.DBA, propertytype.CssSelector);
            // sendkeys for Address1
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx8c2cf029-d365-4cfa-89bc-0d33dd70dc1b", Infosection.Address1, propertytype.CssSelector);
            Globalelements.Address1 = Infosection.Address1;
            // sendkeys for address2
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxa5f9fc3f-7b45-4432-ae7a-91e548bcd4be", Infosection.Address2, propertytype.CssSelector);
            // sendkeys for city
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx70dbfee1-01f7-45d5-8499-4d1d75a8bab0", Infosection.City, propertytype.CssSelector);
            //select state from dropdown
            implicitwait.ImplicitWait(10);
            CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl56b20cb6-929a-480f-a522-8a4dc2a4aa90", Infosection.State, propertytype.CssSelector);
            implicitwait.ImplicitWait(10);
            // WebDriverWait wait = new WebDriverWait(PropertiesCollection.ngdriver, 10);
            // wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx65de1d35-112f-4720-acd1-c7d1ac047183")));
            // send keys for zip
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx65de1d35-112f-4720-acd1-c7d1ac047183", Infosection.Zip.ToString(), propertytype.CssSelector);
            // send keys web site address
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx685578bd-cc46-4fb7-b0c7-af1b0cea0783", Infosection.Website, propertytype.CssSelector);


        }
        [Given(@"conditional to zip should only belong to Alabama")]
        public void GivenConditionalToZipShouldOnlyBelongToAlabama()
        {
             
        }
        
        [Given(@"User fills data for contact information sections as")]
        public void GivenUserFillsDataForContactInformationSectionsAs(Table contactinfo)
        {
            dynamic Contactinfo = contactinfo.CreateDynamicInstance();

            //send keys for title
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxab9780f4-c715-448c-9a40-811da43e5a87",Contactinfo.Title, propertytype.CssSelector);
            //send keys for Name
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxe4d817f2-6eac-432a-a63b-ebac2976cdf8", Contactinfo.Name, propertytype.CssSelector);
            // send keys for phone
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxcc6415ab-05e8-47ba-859b-66fe5d551a30", Contactinfo.Phone.ToString(), propertytype.CssSelector) ; 
            // send keys for email
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx1070ad7f-68de-4c57-83f5-5730dfec076f", Contactinfo.Email, propertytype.CssSelector);
        }
        
        [Given(@"conditional to email and website should be of the format acceptable by the system")]
        public void GivenConditionalToEmailAndWebsiteShouldBeOfTheFormatAcceptableByTheSystem()
        {
             
        }
        
        [Given(@"user fills data for product selection section as")]
        public void GivenUserFillsDataForProductSelectionSectionAs(Table productselection)
        {
            dynamic Productselection = productselection.CreateDynamicInstance();

            //select market segment
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpladac9c07-bcb2-4090-937b-767fbf8fac3f", Productselection.Market_Segment, propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            delayfor.delay();

            // select available form
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl6269d11a-a63c-4b81-83d6-da47d249c77f",  Productselection.Available_Form, propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            delayfor.delay();

            // select product
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl71437492-8fbd-497a-ac84-df35abf2c6e5", Productselection.Product_Selection, propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            delayfor.delay();

            // selct upc
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl53e1c9b1-02b2-47ed-adc6-8257dc60037e", Productselection.UPC, propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            delayfor.delay();
            // select available group
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpla1602ad7-726b-4452-ae07-73469618a59d",Productselection.Account_Group_Type, propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            delayfor.delay();





        }

        [Given(@"user chooses data for Additional information section as")]
        public void GivenUserChoosesDataForAdditionalInformationSectionAs(Table sic)
        {
            dynamic SIC = sic.CreateDynamicInstance();
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxf17a9de8-10cf-4b56-9caa-96e70c0f8d85", SIC.SIC, propertytype.CssSelector);
            delayfor.delay();

            // select first option
            CustomControls.click("//div[@id='114ctgroup']", propertytype.XPath);



        }
        
        [Given(@"user selects Account Representatives as")]
        public void GivenUserSelectsAccountRepresentativesAs(Table repr)
        {
             dynamic Repr= repr.CreateDynamicInstance();

            //underwriting Analyst

            CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl55bfb7f4-3328-4677-8e0b-802fb59ac281", Repr.underwriting_Analsyst, propertytype.CssSelector);

            // select dist.manager

            CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drplae6440fd-28d2-4737-b6fd-789c17e6c450", Repr.Reg_Distribution_Mgr, propertytype.CssSelector);
        }
        
        [Given(@"user clicks Next button to move to the next page")]
        public void GivenUserClicksNextButtonToMoveToTheNextPage()
        {
            CustomControls.click("#ctl00_cphMain_btnbuttonSubmissionSaveSave", propertytype.CssSelector);
        }
    }
}
