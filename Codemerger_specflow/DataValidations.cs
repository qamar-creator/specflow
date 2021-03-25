
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codemerger_specflow
{
    class DataValidations
    {
        public static void Locationinfosdatavalidations()
        {
            implicitwait.ImplicitWait(15);
            string locationname = CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_answercontrol0dde0383aa544b619da8a83fac6b54b49R1C0B2685_DRepeatertableC2D8F244A5EB457DAF89BC545C8D8F6E_childgridviewc2d8f244a5eb457daf89bc545c8d8f6eR1_txtxa6b68ca1-7bfb-45af-b8ba-76e97135a67c", propertytype.CssSelector);
            Assert.AreEqual(locationname, Globalelements.locationinfo, "The location name in submission form and subsidary form do not match");

            implicitwait.ImplicitWait(5);
            string address1 = CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_answercontrol0dde0383aa544b619da8a83fac6b54b49R1C0B2685_DRepeatertableC2D8F244A5EB457DAF89BC545C8D8F6E_childgridviewc2d8f244a5eb457daf89bc545c8d8f6eR1_txtx91576e45-d815-4cf2-8172-0cfa539a7205", propertytype.CssSelector);
            Assert.AreEqual(address1, Globalelements.Address1, "  Address1 in submission form and subsidary form do not match");


        }
    }
}
