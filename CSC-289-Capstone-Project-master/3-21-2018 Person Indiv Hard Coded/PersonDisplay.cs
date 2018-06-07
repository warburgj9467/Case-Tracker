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

namespace database.Forms
{
    public partial class personForm : Form
    {
        Person person = new Person();
        public personForm()
        {
            InitializeComponent();
        }

        private void populateButton_Click(object sender, EventArgs e)
        {
            string lastName;
            string firstName;
            string gender;
            string race;
            string dob;
            string ssn;
            bool mil;
            string church;
            string address;
            string apartment;
            string city;
            string state;
            int zip;
            string email;
            string homePhone;
            string mobilePhone;
            string workPhone;

            lastName = person.lastName;
            firstName = person.firstName;
            gender = person.gender;
            race = person.race;
            dob = person.dob;
            ssn = person.ssn;
            mil = person.milDependent;
            church = person.churchConnection;
            address = person.streetAddress;
            apartment = person.apartment;
            city = person.city;
            state = person.state;
            zip = person.zip;
            email = person.email;
            homePhone = person.homePhone;
            mobilePhone = person.mobilePhone;
            workPhone = person.workPhone;

            lastNameLabel.Text = lastName.ToString();
            firstNameLabel.Text = firstName.ToString();
            genderLabel.Text = gender.ToString();
            raceLabel.Text = race.ToString();
            dobLable.Text = dob.ToString();
            ssnLabel.Text = ssn.ToString();
            if (mil == true)
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
