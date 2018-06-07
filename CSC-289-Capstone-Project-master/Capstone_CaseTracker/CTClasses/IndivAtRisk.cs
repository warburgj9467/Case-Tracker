using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTClasses
{
    public class IndivAtRisk : Person
    {
        public string indivID { get; set; } //auto generated PK from DB table: indivAtRisk
        private string _schoolName;
        private string _teacherName;
        private string _schoolTelephone;
        private string _abuse;
        private string _neglect;        

        public IndivAtRisk()// no arg constructor
        { }

        //Constructor, note: indivID and personID are auto generated in the DB (no setter methods)
        public IndivAtRisk(string personId, string lastName, string firstName, string gender, string race,
            string dob, string ssn, string streetAddress, string apartment,
            string city, string state, string zip, string email, string homePhone, string mobilePhone, string workPhone,
            string churchConnection, string milDependent, string type, string schoolName, string teacherName,
            string schoolTelephone, string abuse, string neglect) : base(personId, lastName, firstName, gender,
                race, dob, ssn, streetAddress, apartment, city, state, zip, email, homePhone, mobilePhone, workPhone,
                churchConnection, milDependent, type)

        {
            // IndivID = _indivID; //populated from the DB
            _schoolName = schoolName;
            _teacherName = teacherName;
            _schoolTelephone = schoolTelephone;
            _abuse = abuse;
            _neglect = neglect;
        }




        //setters and getters
        //public string IndivID 
        //{
        //     get {return _indivID; }
        //}                                            //no setter
        public string SchoolName
        {
            get { return _schoolName; }
            set { _schoolName = value; }
        }
        public string TeacherName
        {
            get { return _teacherName; }
            set { _teacherName = value; }
        }
        public string SchoolTelephone
        {
            get { return _schoolTelephone; }
            set { _schoolTelephone = value; }
        }
        public string abuse
        {
            get { return _abuse; }
            set { _abuse = value; }
        }
        public string Neglect
        {
            get { return _neglect; }
            set { _neglect = value; }
        }

        //public void setDefaults()//this method allows us to test form and to test hard code and/or user input
        //{
        //    this.firstName = "Josephine";
        //    this.lastName = "Belmont";
        //    this.gender = "Female";
        //    this.race = "Caucasian";
        //    this.dob = "2-10-2015";
        //    this.ssn = "111-22-3333";
        //    this.streetAddress = "123 main st.";
        //    this.apartment = "2F";
        //    this.city = "Fayetteville";
        //    this.zip = "28303";
        //    this.homePhone = "910-123-4567";
        //    this.churchConnection = "1st Baptist, Raeford Rd";
        //    this.milDependent = "Yes";
        //    this.SchoolName = "FTCC day care";
        //    this.TeacherName = "Mrs.Cane";
        //    this.SchoolTelephone = "940-284-5678";
        //    this.abuse = "Yes";
        //    this.Neglect = "Yes";
        //}
    }
}
