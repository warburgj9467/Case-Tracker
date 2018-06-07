using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassEngine;
//using System.Data.SqlClient;

namespace database.Forms
{
    public partial class personForm : Form
    {        
        public personForm()
        {
            InitializeComponent();
        }
        //SQLCommands commands = new SQLCommands();
        
        private void populateButton_Click(object sender, EventArgs e)
        {
            //var person = new Person();
            //string lastName;
            //string firstName;
            string lastName2;
            string firstName2;
            string gender;
            string race;
            string dob;
            string ssn;
            string milDependent;
            string church;
            string address;
            string apartment;
            string city;
            string state;
            string zip;
            string email;
            string homePhone;
            string mobilePhone;
            string workPhone;

            //lastName = lastNameTextBox.Text;
            //firstName = firstNameTextBox.Text;

            //person = commands.RetrievePersonData(lastName, firstName);
            Person person = new Person();

            lastName2 = person.lastName.ToString();
            firstName2 = person.firstName.ToString();
            gender = person.gender.ToString();
            race = person.race.ToString();
            dob = person.dob.ToString();
            ssn = person.ssn.ToString();
            milDependent = person.milDependent.ToString();
            church = person.churchConnection.ToString();
            address = person.streetAddress.ToString();
            apartment = person.apartment.ToString();
            city = person.city.ToString();
            state = person.state.ToString();
            zip = person.zip.ToString();
            email = person.email.ToString();
            homePhone = person.homePhone.ToString();
            mobilePhone = person.mobilePhone.ToString();
            workPhone = person.workPhone.ToString();

            lastNameLabel.Text = lastName2.ToString();
            firstNameLabel.Text = firstName2.ToString();
            genderLabel.Text = gender.ToString();
            raceLabel.Text = race.ToString();
            dobLable.Text = dob.ToString();
            ssnLabel.Text = ssn.ToString();
            if (person.milDependent.ToString() == "y" || person.milDependent.ToString() == "Y")
            {
                milLabel.Text = "yes";
            }
            else
            {
                milLabel.Text = "no";
            }
            churchLabel.Text = church.ToString();
            addressLabel.Text = address.ToString();
            apartmentLabel.Text = apartment.ToString();
            cityLabel.Text = city.ToString();
            stateLabel.Text = state.ToString();
            zipLabel.Text = zip.ToString();
            emailLabel.Text = email.ToString();
            homePhoneLabel.Text = homePhone.ToString();
            mobilePhoneLabel.Text = mobilePhone.ToString();
            workPhoneLabel.Text = workPhone.ToString();
        }
    }
}
