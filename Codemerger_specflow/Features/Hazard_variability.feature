Feature:b_ Hazard_variability
In this feature , we have all the requirements for testing the hazard_Variability
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
![screenshot](https://dev.azure.com/InsurIQ/c280b3f7-9ae4-45a2-b5fe-9132ba656c59/_apis/wit/attachments/93a0861d-987d-4b81-ada2-4bcf9dacd0f3?fileName=code%20behind%20the%20files.PNG)
@Hazard_Variability_AL
Scenario:Hazrad_Varibility _State Alabama UVA-Basic
 
Given User should be successfully logged in the application
And user clicks underwriter.
And user clicks New RFP.
And user sets data for the Submission screen viz different sections in the application
And user fills/picks dates for proposed due date and effective due date
| propsed_due_date | Effective_date |
| 2/11/2020        | 2/20/2020      | 
And user fills data for Information section as
| Policy_holder_name | DBA | Address1    | Address2     | City         | State   | Zip    | Website       |
| Automation_toda    | DBA | House no.10 | Jackson Lane | Alabama City | Alabama |	35242 | www.gboiq.com |
And conditional to zip should only belong to Alabama
And User fills data for contact information sections as
| Title                    | Name          | Phone      | Email         |
| HazardVaraibilty_Alabama | James Jackson | 0986671666 | Gbo@email.com |
And conditional to email and website should be of the format acceptable by the system
And user fills data for product selection section as
| Market_Segment | Available_Form | Product_Selection | UPC                       | Account_Group_Type    |
| Corporate      | U-VA-1001-B    | Basic AD&D        | 0866 - CARVEOUT PRINCIPAL | Employers (employees) |
And user chooses data for Additional information section as
| SIC|
| (1100)ANTHRACITE MINING |
And user selects Account Representatives as
| underwriting_Analsyst | Reg_Distribution_Mgr |
| System User           | S Test               |
And user clicks Next button to move to the next page
