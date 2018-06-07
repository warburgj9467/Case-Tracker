using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTClasses
{
    class Case
    {
        //private string _caseID;             //when DB goes live
        private IndivAtRisk _indiv;
        private CareGiver _careGiver;
        private PersonOfInterest _personOfInterest;
        private SocialWorker _socialWorker;
        private CaseHistory _caseHistory;

        public Case()
        {   //no arg constructor
        }
        //constructor with parameters
        public Case(  //string caseID,
            IndivAtRisk indiv, CareGiver careGiver, PersonOfInterest personOfInterest, SocialWorker socialWorker,
            CaseHistory caseHistory)
        {
            // caseID = _caseID;
            indiv = _indiv;
            careGiver = _careGiver;
            personOfInterest = _personOfInterest;
            socialWorker = _socialWorker;
            caseHistory = _caseHistory;
        }

        //setters and getters
        //public string caseID
        //{
        //    get { return _caseID; }      //getter only, _caseID will be generated in the DB
        //}
        public IndivAtRisk indiv
        {
            get { return _indiv; }
            set { _indiv = value; }
        }
        public CareGiver careGiver
        {
            get { return _careGiver; }
            set { _careGiver = value; }
        }
        public PersonOfInterest personOfInterest
        {
            get { return _personOfInterest; }
            set { _personOfInterest = value; }
        }
        public SocialWorker socialWorker
        {
            get { return _socialWorker; }
            set { _socialWorker = value; }
        }
        public CaseHistory caseHistory
        {
            get { return _caseHistory; }
            set { _caseHistory = value; }
        }

        public void setDefaults()
        {
            this.indiv.firstName = "Tina";
            this.indiv.lastName = "CaseIndivLastName";
            this.careGiver.firstName = "CaseCareGiverFirstName";
            this.careGiver.lastName = "CaseCareGiverLastName";
            this.personOfInterest.lastName = "CasePersonOfInterestLastName";
            this.socialWorker.lastName = "CaseSocialWorkerLastName";
            this.caseHistory.houseEnvironmentNote = "CaseCaseHistoryHouseEnvironmentNote";
        }
    }
}
