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
    public partial class PersonForm : Form
    {
        IndivAtRisk indiv = new IndivAtRisk();
        PersonOfInterest poi = new PersonOfInterest();
        CareGiver care = new CareGiver();
        SQLCommands com = new SQLCommands();
        public PersonForm()
        {
            InitializeComponent();            
        }

        int personId;
        int indivId;
        string lastName;
        string firstName;
        string dob;
        string ssn;
        string race;
        string gender;
        string milcon;
        string church;
        string streetAddress;
        string apartment;
        string city;
        string state;
        string zip;
        string email;
        string homePhone;
        string workPhone;
        string mobilePhone;
        string type;

        private void indivSaveButton_Click(object sender, EventArgs e)
        {
            
            string school;
            string teacher;
            string schoolPhone;
            string abuse;
            string neglect;

            indiv.lastName = indivLastNameTextBox.Text;
            indiv.firstName = indivFirstNameTextBox.Text;
            indiv.dob = indivDOBTextBox.Text;
            indiv.ssn = indivSSNTextBox.Text;
            indiv.race = indivRaceTextBox.Text;
            indiv.gender = indivGenderTextBox.Text;
            indiv.milDependent = indivMilitaryDependentTextBox.Text;
            indiv.churchConnection = indivChurchTextBox.Text;
            indiv.streetAddress = indivAddressTextBox.Text;
            indiv.apartment = indivApartmentTextBox.Text;
            indiv.city = indivCityTextBox.Text;
            indiv.state = indivStateTextBox.Text;
            indiv.zip = indivZipTextBox.Text;
            indiv.email = indivEmailTextBox.Text;
            indiv.homePhone = indivHomePhoneTextBox.Text;
            indiv.workPhone = indivWorkPhoneTextBox.Text;
            indiv.mobilePhone = indivMobilePhoneTextBox.Text;
            indiv.type = indivTypeTextBox.Text;
            indiv.SchoolName = indivSchoolTextBox.Text;
            indiv.TeacherName = indivTeacherTextBox.Text;
            indiv.SchoolTelephone = indivSchoolPhoneTextBox.Text;
            indiv.abuse = indivAbuseTextBox.Text;
            indiv.Neglect = indivNeglectTextBox.Text;

            lastName = indiv.lastName;
            firstName = indiv.firstName;
            dob = indiv.dob;
            ssn = indiv.ssn;
            race = indiv.race;
            gender = indiv.gender;
            milcon = indiv.milDependent;
            church = indiv.churchConnection;
            streetAddress = indiv.streetAddress;
            apartment = indiv.apartment;
            city = indiv.city;
            state = indiv.state;
            zip = indiv.zip;
            email = indiv.email;
            homePhone = indiv.homePhone;
            workPhone = indiv.workPhone;
            mobilePhone = indiv.mobilePhone;
            type = indiv.type;
            school = indiv.SchoolName;
            teacher = indiv.TeacherName;
            schoolPhone = indiv.SchoolTelephone;
            abuse = indiv.abuse;
            neglect = indiv.Neglect;

            com.PersonDataSave(lastName, firstName, gender, race, milcon, dob, ssn, church, streetAddress, apartment, city, state, zip, email, homePhone, workPhone, mobilePhone, type);
            com.PersonId();
            var indiv2 = com.PersonId();
            personId = int.Parse(indiv2.personId);            
            com.IndivDataSave(personId, teacher, school, schoolPhone, abuse, neglect);
            indivSaveButton.Visible = false;
        }

        private void poiSaveButton_Click(object sender, EventArgs e)
        {
            string relationship;

            poi.lastName = poiLastNameTextBox.Text;
            poi.firstName = poiFirstNameTextBox.Text;
            poi.dob = poiDOBTextBox.Text;
            poi.ssn = poiSSNTextBox.Text;
            poi.race = poiRaceTextBox.Text;
            poi.gender = poiGenderTextBox.Text;
            poi.milDependent = poiMILTextBox.Text;
            poi.churchConnection = poiChurchTextBox.Text;
            poi.streetAddress = poiAddressTextBox.Text;
            poi.apartment = poiApartmentTextBox.Text;
            poi.city = poiCityTextBox.Text;
            poi.state = poiStateTextBox.Text;
            poi.zip = poiZipTextBox.Text;
            poi.email = poiEmailTextBox.Text;
            poi.homePhone = poiHomePhoneTextBox.Text;
            poi.workPhone = poiWorkPhoneTextBox.Text;
            poi.mobilePhone = poiMobilePhoneTextBox.Text;
            poi.type = poiTypeTextBox.Text;
            poi.relationship = poiRelationshipTextBox.Text;

            lastName = poi.lastName;
            firstName = poi.firstName;
            dob = poi.dob;
            ssn = poi.ssn;
            race = poi.race;
            gender = poi.gender;
            milcon = poi.milDependent;
            church = poi.churchConnection;
            streetAddress = poi.streetAddress;
            apartment = poi.apartment;
            city = poi.city;
            state = poi.state;
            zip = poi.zip;
            email = poi.email;
            homePhone = poi.homePhone;
            workPhone = poi.workPhone;
            mobilePhone = poi.mobilePhone;
            type = poi.type;
            relationship = poi.relationship;

            com.PersonDataSave(lastName, firstName, gender, race, milcon, dob, ssn, church, streetAddress, apartment, city, state, zip, email, homePhone, workPhone, mobilePhone, type);
            var indiv2 = com.PersonId();
            personId = int.Parse(indiv2.personId);
            var poi2 = com.IndivId();
            indivId = int.Parse(poi2.indivId);
            com.PersonOfInterestSaveData(personId, indivId, relationship);

            poiSaveButton.Visible = false;
        }

        private void careSaveButton_Click(object sender, EventArgs e)
        {
            string relationship;

            care.lastName = careLastNameTextBox.Text;
            care.firstName = careFirstNameTextBox.Text;
            care.dob = careDOBTextBox.Text;
            care.ssn = careSSNTextBox.Text;
            care.race = careRaceTextBox.Text;
            care.gender = careGenderTextBox.Text;
            care.milDependent = careMilitaryDependentTextBox.Text;
            care.churchConnection = careChurchTextBox.Text;
            care.streetAddress = careAddressTextBox.Text;
            care.apartment = careApartmentTextBox.Text;
            care.city = careCityTextBox.Text;
            care.state = careStateTextBox.Text;
            care.zip = careZipTextBox.Text;
            care.email = careEmailTextBox.Text;
            care.homePhone = careHomePhoneTextBox.Text;
            care.workPhone = careWorkPhoneTextBox.Text;
            care.mobilePhone = careMobileTextBox.Text;
            care.type = carePersonTypeTextBox.Text;
            care.relationship = careRelationshipTextBox.Text;

            lastName = care.lastName;
            firstName = care.firstName;
            dob = care.dob;
            ssn = care.ssn;
            race = care.race;
            gender = care.gender;
            milcon = care.milDependent;
            church = care.churchConnection;
            streetAddress = care.streetAddress;
            apartment = care.apartment;
            city = care.city;
            state = care.state;
            zip = care.zip;
            email = care.email;
            homePhone = care.homePhone;
            workPhone = care.workPhone;
            mobilePhone = care.mobilePhone;
            type = care.type;
            relationship = care.relationship;

            com.PersonDataSave(lastName, firstName, gender, race, milcon, dob, ssn, church, streetAddress, apartment, city, state, zip, email, homePhone, workPhone, mobilePhone, type);
            var indiv2 = com.PersonId();
            personId = int.Parse(indiv2.personId);
            var care2 = com.CareIndivId();
            indivId = int.Parse(care2.indivId);
            com.CareGiverSaveData(personId, indivId, relationship);
        }        
    }
}
