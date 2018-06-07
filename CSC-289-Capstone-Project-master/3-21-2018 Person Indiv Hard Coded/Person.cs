using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEngine
{
    public class Person
    {
        //private int _personId; Database only so no need to have it for testing purposes
        private string _lastName;
        private string _firstName;
        private string _gender;
        private string _race;
        private string _dob;
        private string _ssn;
        private bool _milDependent;
        private string _churchConnection;
        private string _streetAddress;
        private string _apartment;
        private string _city;
        private string _state;
        private int _zip;
        private string _email;
        private string _homePhone;
        private string _mobilePhone;
        private string _workPhone;

        public Person()
        {
            _lastName = "Cellini";
            _firstName = "Angela";
            _gender = "Female";
            _race = "caucasian";
            _dob = "March 6, 2000";
            _ssn = "111-22-3333";
            _milDependent = false;
            _churchConnection = "Saint Mary's";
            _streetAddress = "123 Main Street";
            _apartment = "C6";
            _city = "Fayetteville";
            _state = "NC";
            _zip = 28303;
            _email = " ";
            _homePhone = "910-123-4567";
            _mobilePhone = " ";
            _workPhone = " ";
        }
        public Person(string lastName, string firstName, string gender, string race, string dob, string ssn, bool milDependent, string churchConnection, string streetAddress,
            string apartment, string city, string state, int zip, string email, string homePhone, string mobilePhone, string workPhone)
        {
            lastName = _lastName;
            firstName = _firstName;
            gender = _gender;
            race = _race;
            dob = _dob;
            ssn = _ssn;
            milDependent = _milDependent;
            churchConnection = _churchConnection;
            streetAddress = _streetAddress;
            apartment = _apartment;
            city = _city;
            state = _state;
            zip = _zip;
            email = _email;
            homePhone = _homePhone;
            mobilePhone = _mobilePhone;
            workPhone = _workPhone;
        }

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string race
        {
            get { return _race; }
            set { _race = value; }
        }
        public string dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
        public string ssn
        {
            get { return _ssn; }
            set { _ssn = value; }
        }
        public bool milDependent
        {
            get { return _milDependent; }
            set { _milDependent = value; }
        }
        public string churchConnection
        {
            get { return _churchConnection; }
            set { _churchConnection = value; }
        }
        public string streetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }
        public string apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }
        public string state
        {
            get { return _state; }
            set { _state = value; }
        }
        public int zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string homePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }
        public string mobilePhone
        {
            get { return _mobilePhone; }
            set { _mobilePhone = value; }
        }
        public string workPhone
        {
            get { return _workPhone; }
            set { _workPhone = value; }
        }
    }
}