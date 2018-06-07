using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTClasses
{
    public class SocialWorker
    {
        //private string _socialWorkerID;    //these two fields will be added in when the DB goes live and to test the DB
        //private string _userID;
        private string _lastName;
        private string _firstName;
        private string _officeAddress;
        private string _workPhone;
        private string _mobilePhone;
        private string _email;

        public SocialWorker()   //no arg constructor used to create object with no parameters
        { }
        //constructor with parameters
        public SocialWorker( // string socialWorkerID, string userID,
            string lastName, string firstName, string officeAddress, string workPhone, string mobilePhone, string email)
        {
            //socialWorkerID = _socialWorkerID;
            //userID = _userID;
            lastName = _lastName;
            firstName = _firstName;
            officeAddress = _officeAddress;
            workPhone = _workPhone;
            mobilePhone = _mobilePhone;
            email = _email;
        }
        //setters and getters, string ID's have no setters, they will be generated in the DB

        // public string socialWorkerID              //these two getters will be used when DB is engaged
        //{
        //    get { return _socialWorkerID;}
        //}
        //public string userID
        //{
        //    get { return _userID; }            
        //}
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
        public string officeAddress
        {
            get { return _officeAddress; }
            set { _officeAddress = value; }
        }
        public string workPhone
        {
            get { return _workPhone; }
            set { _workPhone = value; }
        }
        public string mobilePhone
        {
            get { return _mobilePhone; }
            set { _mobilePhone = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public void setDefaults()
        {
            this.firstName = "Suzanne";
            this.lastName = "Jenkins";
            this.officeAddress = "123 Ramsey St. DSS Bldg.";
            this.workPhone = "910-123-4567";
            this.mobilePhone = "010-987-5678";
            this.email = "sjenkins@dss.com";
        }
    }
}
