using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTClasses
{
    public class Input : Person
    {
        private string _type;

        public Input()
        {
            _type = " ";
        }

        public Input(string personId, string lastName, string firstName, string dob, string ssn, string race, string gender, string streetAddress, string apartment, string city, string state,
            string zip, string email, string homePhone, string mobilePhone, string workPhone,
            string churchConnection, string milDependent, string type) : base (personId, lastName, firstName, 
            gender, race, dob, ssn, streetAddress, apartment, city, state, zip, email, homePhone, 
            mobilePhone, workPhone, churchConnection, milDependent, type)
        {
            type = _type;
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
