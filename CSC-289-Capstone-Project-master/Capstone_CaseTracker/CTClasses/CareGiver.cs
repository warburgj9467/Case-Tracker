using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTClasses
{
    public class CareGiver : Person
    {
        //private string _careGiverID;  these items will be used later when we hook up with the DB
        //private string _personID;
        public string indivId { get; set; }  
        private string _relationship;  //to describe what the relationship of the care giver is to the indivAtRisk

        public CareGiver()// no arg constructor
        { }
        //string careGiverID, string personID and string indivID to be added as parameters later when DB is active
        public CareGiver(string personId, string lastName, string firstName, string gender, string race,
        string dob, string ssn, string streetAddress, string apartment,
        string city, string state, string zip, string email, string homePhone, string mobilePhone, string workPhone,
        string churchConnection, string milDependent, string type, string relationship) : base(personId, lastName, firstName, gender,
            race, dob, ssn, streetAddress, apartment, city, state, zip, email, homePhone, mobilePhone, workPhone,
            churchConnection, milDependent, type)
        {
            //_careGiverID = careGiverID;    //to be used when DB is alive
            //_personID = personID;
            //_indivID = indivID;
            _relationship = relationship;
        }

        //setters and getters
        public string relationship
        {
            get { return _relationship; }
            set { _relationship = value; }
        }
        //public string careGiverID                    //getters only for DB generated ID fields
        //{
        //    get { return _careGiverID; }
        //}
        //public string personID
        //{
        //    get { return _personID; }
        //}
        //public string indivID
        //{
        //    get { return _indivID; }
        //}

        public void setDefaults() //hard coded data for test purpose.  putting it into a separate method allows
        {                         //us to not call/use it and we can do something else instead like let the user
            this.firstName = "Joanna";  //enter data
            this.lastName = "Allonton";
            this.relationship = "mother";
        }



    }
}
