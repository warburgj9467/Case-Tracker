using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CTClasses;


namespace Capstone_CaseTracker
{
    public partial class CaseView : Form
    {        
        PersonOfInterest bad;
        SocialWorker socialWkr;
        CaseHistory case1;
        SQLCommands com = new SQLCommands();


        public CaseView(string lastName)
        {

            InitializeComponent();
            indivLastNameTextBox.Text = lastName.ToString();
            string lastName2 = indivLastNameTextBox.Text;
            var indiv = com.RetrieveIndivData(lastName2);
            int indivId = int.Parse(indiv.indivID);
            //var giver = com.RetrieveCareGiverData();
            //var poi = com.RetrievePersonOfInt();            

            indivPersonIdLabel.Text = indiv.personId;
            indivFirstNameTextBox.Text = indiv.firstName;                        
            indivDOBTextBox.Text = indiv.dob;
            indivSSNTextBox.Text = indiv.ssn;
            indivRaceTextBox.Text = indiv.race;
            indivGenderTextBox.Text = indiv.gender;
            indivMilitaryDependentTextBox.Text = indiv.milDependent;
            indivChurchTextBox.Text = indiv.churchConnection;
            indivAddressTextBox.Text = indiv.streetAddress;
            indivApartmentTextBox.Text = indiv.apartment;
            indivCityTextBox.Text = indiv.city;
            indivStateTextBox.Text = indiv.state;
            indivZipTextBox.Text = indiv.zip;
            indivHomePhoneTextBox.Text = indiv.homePhone;
            indivMobilePhoneTextBox.Text = indiv.mobilePhone;            
            indivSchoolTextBox.Text = indiv.SchoolName;
            indivTeacherTextBox.Text = indiv.TeacherName;
            indivSchoolPhoneTextBox.Text = indiv.SchoolTelephone;
            indivAbuseTextBox.Text = indiv.abuse;
            indivNeglectTextBox.Text = indiv.Neglect;

            var giver = com.RetrieveCareGiverData(indivId);
            carePersonIdLabel.Text = giver.personId;
            careFirstNameTextBox.Text = giver.firstName;
            careLastNameTextBox.Text = giver.lastName;
            careDOBTextBox.Text = giver.dob;
            careSSNTextBox.Text = giver.ssn;
            careRaceTextBox.Text = giver.race;
            careGenderTextBox.Text = giver.gender;
            careMilitaryDependentTextBox.Text = giver.milDependent;
            careChurchTextBox.Text = giver.churchConnection;
            careAddressTextBox.Text = giver.streetAddress;
            careApartmentTextBox.Text = giver.apartment;
            careCityTextBox.Text = giver.city;
            careStateTextBox.Text = giver.state;
            careZipTextBox.Text = giver.zip;
            careRelationshipTextBox.Text = giver.relationship;
            careHomePhoneTextBox.Text = giver.homePhone;
            careMobileTextBox.Text = giver.mobilePhone;
            careWorkPhoneTextBox.Text = giver.workPhone;
            careEmailTextBox.Text = giver.email;
            carePersonTypeTextBox.Text = giver.type;

            var poi = com.RetrievePersonOfInt(indivId);
            poiPersonIdLabel.Text = poi.personId;
            poiFirstNameTextBox.Text = poi.firstName;
            poiLastNameTextBox.Text = poi.lastName;
            poiDOBTextBox.Text = poi.dob;
            poiRaceTextBox.Text = poi.race;
            poiGenderTextBox.Text = poi.gender;
            poiSSNTextBox.Text = poi.ssn;
            poiMILTextBox.Text = poi.milDependent;
            poiChurchTextBox.Text = poi.churchConnection;
            poiAddressTextBox.Text = poi.streetAddress;
            poiApartmentTextBox.Text = poi.apartment;
            poiCityTextBox.Text = poi.city;
            poiStateTextBox.Text = poi.state;
            poiZipTextBox.Text = poi.zip;
            poiHomePhoneTextBox.Text = poi.homePhone;
            poiMobilePhoneTextBox.Text = poi.mobilePhone;
            poiWorkPhoneTextBox.Text = poi.workPhone;
            poiEmailTextBox.Text = poi.email;
            poiTypeTextBox.Text = poi.type;
            poiRelationshipTextBox.Text = poi.relationship;
        }

        int personId;
        string lastName;
        string firstName;
        string gender;
        string race;
        string milcon;
        string dob;
        string ssn;
        string church;
        string streetAddress;
        string apartment;
        string city;
        string state;
        string zip;
        string email;
        string homephone;        
        string mobilePhone;        

        private void exitCaseViewButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void indivUpdateButton_Click(object sender, EventArgs e)
        {
            string school;
            string teacher;
            string schoolPhone;
            string abuse;
            string neglect;

            personId = int.Parse(indivPersonIdLabel.Text);            
            lastName = indivLastNameTextBox.Text;
            firstName = indivFirstNameTextBox.Text;
            dob = indivDOBTextBox.Text;
            ssn = indivSSNTextBox.Text;
            gender = indivGenderTextBox.Text;
            race = indivRaceTextBox.Text;            
            milcon = indivMilitaryDependentTextBox.Text;
            church = indivChurchTextBox.Text;
            streetAddress = indivAddressTextBox.Text;
            apartment = indivApartmentTextBox.Text;
            city = indivCityTextBox.Text;
            state = indivStateTextBox.Text;
            zip = indivZipTextBox.Text;
            email = indivEmailTextBox.Text;
            homephone = indivHomePhoneTextBox.Text;
            mobilePhone = indivMobilePhoneTextBox.Text;
            
            school = indivSchoolTextBox.Text;
            teacher = indivTeacherTextBox.Text;
            schoolPhone = indivSchoolPhoneTextBox.Text;
            abuse = indivAbuseTextBox.Text;
            neglect = indivNeglectTextBox.Text;

            com.UpdatePersonData(personId, lastName, firstName, dob, ssn, race, gender, milcon, church, streetAddress, apartment, city, state, zip, email, homephone, mobilePhone);
            com.UpdateIndividualData(personId, school, teacher, schoolPhone, abuse, neglect);
        }

        private void careUpdateButton_Click(object sender, EventArgs e)
        {
            string relationship;

            personId = int.Parse(carePersonIdLabel.Text);
            lastName = careLastNameTextBox.Text;
            firstName = careFirstNameTextBox.Text;
            dob = careDOBTextBox.Text;
            ssn = careSSNTextBox.Text;
            gender = careGenderTextBox.Text;
            race = careRaceTextBox.Text;
            milcon = careMilitaryDependentTextBox.Text;
            church = careChurchTextBox.Text;
            streetAddress = careAddressTextBox.Text;
            apartment = careApartmentTextBox.Text;
            city = careCityTextBox.Text;
            state = careStateTextBox.Text;
            zip = careZipTextBox.Text;
            email = careEmailTextBox.Text;
            homephone = careHomePhoneTextBox.Text;
            mobilePhone = careMobileTextBox.Text;
            relationship = careRelationshipTextBox.Text;            

            com.UpdatePersonData(personId, lastName, firstName, dob, ssn, race, gender, milcon, church, streetAddress, apartment, city, state, zip, email, homephone, mobilePhone);
            com.UpdateCareGiverData(personId, relationship);
        }

        private void poiUpdateButton_Click(object sender, EventArgs e)
        {
            string relationship;

            personId = int.Parse(poiPersonIdLabel.Text);
            lastName = poiLastNameTextBox.Text;
            firstName = poiFirstNameTextBox.Text;
            dob = poiDOBTextBox.Text;
            ssn = poiSSNTextBox.Text;
            gender = poiGenderTextBox.Text;
            race = poiRaceTextBox.Text;
            milcon = poiMILTextBox.Text;
            church = poiChurchTextBox.Text;
            streetAddress = poiAddressTextBox.Text;
            apartment = poiApartmentTextBox.Text;
            city = poiCityTextBox.Text;
            state = poiStateTextBox.Text;
            zip = poiZipTextBox.Text;
            email = poiEmailTextBox.Text;
            homephone = poiHomePhoneTextBox.Text;
            mobilePhone = poiMobilePhoneTextBox.Text;
            relationship = poiRelationshipTextBox.Text;

            com.UpdatePersonData(personId, lastName, firstName, dob, ssn, race, gender, milcon, church, streetAddress, apartment, city, state, zip, email, homephone, mobilePhone);
            com.UpdatePOIData(personId, relationship);
        }

        private void indivZipLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
