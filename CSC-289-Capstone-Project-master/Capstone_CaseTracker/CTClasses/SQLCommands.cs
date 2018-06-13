using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace CTClasses
{
    public class SQLCommands
    {
        System.Data.SqlClient.SqlConnection sqlConnection1;

        private System.Data.SqlClient.SqlConnection InitializeConnectionString()
        {
            string temp = Path.GetFullPath("ClassTrackDB.mdf");
            return new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + temp + ";Integrated Security=True");
        }

        //1)This method will call up the login table and check the provided username and password. If they match, it will return true, allowing access.
        //If they do not match, false will be returned and the user will be given a chance to input their username and password again.
        public bool LogInRetrieval(string userName, string password)
        {
            CTClasses.Login login = new CTClasses.Login();
            sqlConnection1 = InitializeConnectionString();
            using (sqlConnection1)
            {
                string data = "Select * from LogIn Where UserName = '" + userName + "'";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);
                sqlConnection1.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        login._username = read["UserName"].ToString();
                        login._password = read["Password"].ToString();
                    }
                }
            }
            sqlConnection1.Close();
                 
            if (login._username == userName && login._password == password)
            {
                bool logIn = true;
                return logIn;
            }
            else
            {
                bool logIn = false;
                return logIn;
            }
        }

        //2)This is connected to the Case List form. It pulls the names from the Persons table that are all listed as an Individual person type. It returns the both the 
        //first and last name. It then loads it into a list box on the form
        public List<string> RetrieveNameList()
        {
            var names = new List<string>();
            IndivAtRisk indiv = new IndivAtRisk();

            sqlConnection1 = InitializeConnectionString();

            using (sqlConnection1)
            {
                string data = "Select Last_Name, First_Name from Persons where Persons.Person_Type = 'INDIVIDUAL'";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);
                sqlConnection1.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        indiv.lastName = read["Last_Name"].ToString();
                        indiv.firstName = read["First_Name"].ToString();
                        string fullName = indiv.firstName.ToString() + " " + indiv.lastName.ToString();
                        names.Add(fullName);
                    }
                }
            }
            sqlConnection1.Close();
            return names;
        }

        //3)Once a case is chosen, this will load the data from the Persons table and data from the IndividualAtRisk table and loads it into the Individual tab on the
        //Case View form.
        public IndivAtRisk RetrieveIndivData(string lastName2)
        {
            var indiv = new IndivAtRisk();
            
            sqlConnection1 = InitializeConnectionString();

            using (sqlConnection1)
            {
                string data = "Select * from Persons, IndividualAtRisk where Last_Name ='" + lastName2 + "' AND IndividualAtRisk.PersonId = Persons.PersonId";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);
                sqlConnection1.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {

                        indiv.personId = read["PersonId"].ToString();
                        indiv.indivID = read["IndivId"].ToString();
                        indiv.lastName = read["Last_Name"].ToString();
                        indiv.firstName = read["First_Name"].ToString();
                        indiv.gender = read["Gender"].ToString();
                        indiv.race = read["Race"].ToString();
                        indiv.dob = read["DOB"].ToString();
                        indiv.ssn = read["SSN"].ToString();
                        indiv.milDependent = read["Military_Dependent"].ToString();
                        indiv.churchConnection = read["Church_Connections"].ToString();
                        indiv.streetAddress = read["Street_Address"].ToString();
                        indiv.apartment = read["Apartment_Number"].ToString();
                        indiv.city = read["City"].ToString();
                        indiv.state = read["State"].ToString();
                        indiv.zip = read["Zip_Code"].ToString();
                        indiv.email = read["Email"].ToString();
                        indiv.homePhone = read["Telephone_Home"].ToString();
                        indiv.mobilePhone = read["Telephone_Mobile"].ToString();
                        indiv.workPhone = read["Telephone_Work"].ToString();
                        indiv.type = read["Person_Type"].ToString();
                        indiv.SchoolName = read["School_Name"].ToString();
                        indiv.TeacherName = read["Teachers_Name"].ToString();
                        indiv.SchoolTelephone = read["SchoolResource_Number"].ToString();
                        indiv.abuse = read["Abuse"].ToString();
                        indiv.Neglect = read["Neglect"].ToString();
                        //indiv.personID = read["PersonId"].ToString();
                    }
                }
            }
            sqlConnection1.Close();
            return indiv;
        }

        //4)Once a case is chosen, this will load the data from the Persons table and data from the IndividualAtRisk table and loads it into the Care Giver tab on the
        //Case View form.
        public CareGiver RetrieveCareGiverData(int indivId)
        {
            var giver = new CareGiver();

            sqlConnection1 = InitializeConnectionString();

            using (sqlConnection1)
            {
                string data = "Select * from Persons, CareGiver, IndividualAtRisk where IndividualAtRisk.IndivId = '" + indivId + "' AND IndividualAtRisk.IndivId = CareGiver.IndivId AND Caregiver.PersonId = Persons.PersonId";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);
                sqlConnection1.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {

                        giver.personId = read["PersonId"].ToString();
                        giver.lastName = read["Last_Name"].ToString();
                        giver.firstName = read["First_Name"].ToString();
                        giver.gender = read["Gender"].ToString();
                        giver.race = read["Race"].ToString();
                        giver.dob = read["DOB"].ToString();
                        giver.ssn = read["SSN"].ToString();
                        giver.milDependent = read["Military_Dependent"].ToString();
                        giver.churchConnection = read["Church_Connections"].ToString();
                        giver.streetAddress = read["Street_Address"].ToString();
                        giver.apartment = read["Apartment_Number"].ToString();
                        giver.city = read["City"].ToString();
                        giver.state = read["State"].ToString();
                        giver.zip = read["Zip_Code"].ToString();
                        giver.email = read["Email"].ToString();
                        giver.homePhone = read["Telephone_Home"].ToString();
                        giver.mobilePhone = read["Telephone_Mobile"].ToString();
                        giver.workPhone = read["Telephone_Work"].ToString();
                        giver.type = read["Person_Type"].ToString();
                        giver.relationship = read["Relationship"].ToString();
                    }
                }
            }
            sqlConnection1.Close();
            return giver;
        }

        //5)Once a case is chosen, this will load the data from the Persons table and data from the Person of Interest table and loads it into the Person of Interest tab
        //on the Case View form.
        public PersonOfInterest RetrievePersonOfInt(int indivId)
        {
            var poi = new PersonOfInterest();

            sqlConnection1 = InitializeConnectionString();

            using (sqlConnection1)
            {
                string data = "Select * from Persons, PersonOfInterest, IndividualAtRisk where IndividualAtRisk.IndivId = '" + indivId +"' AND IndividualAtRisk.IndivId = PersonOfInterest.IndivId AND PersonOfInterest.PersonId = Persons.PersonId";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);
                sqlConnection1.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {

                        poi.personId = read["PersonId"].ToString();
                        poi.lastName = read["Last_Name"].ToString();
                        poi.firstName = read["First_Name"].ToString();
                        poi.gender = read["Gender"].ToString();
                        poi.race = read["Race"].ToString();
                        poi.dob = read["DOB"].ToString();
                        poi.ssn = read["SSN"].ToString();
                        poi.milDependent = read["Military_Dependent"].ToString();
                        poi.churchConnection = read["Church_Connections"].ToString();
                        poi.streetAddress = read["Street_Address"].ToString();
                        poi.apartment = read["Apartment_Number"].ToString();
                        poi.city = read["City"].ToString();
                        poi.state = read["State"].ToString();
                        poi.zip = read["Zip_Code"].ToString();
                        poi.email = read["Email"].ToString();
                        poi.homePhone = read["Telephone_Home"].ToString();
                        poi.mobilePhone = read["Telephone_Mobile"].ToString();
                        poi.workPhone = read["Telephone_Work"].ToString();
                        poi.type = read["Person_Type"].ToString();
                        poi.relationship = read["Relationship"].ToString();
                        //indiv.personID = read["PersonId"].ToString();
                    }
                }
            }
            sqlConnection1.Close();
            return poi;
        }

        //6)In the PersonsForm, this will save the Persons data for all the Individual, CareGiver, and Person of Interest tabs to the database in the PersonsForm.
        public void PersonDataSave(string lastName, string firstName, string gender, string race, string milcon, string dob, string ssn, string church, string streetAddress, string apartment, string city, string state, string zip, string email, string homephone, string workPhone, string mobilePhone, string type)
        {
            sqlConnection1 = InitializeConnectionString();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Persons (Last_Name, First_Name, Gender, Race, Military_Dependent, DOB, SSN, Church_Connections, Street_Address, Apartment_Number, City, State, Zip_Code, Email, Telephone_Home, Telephone_Work, Telephone_Mobile, Person_Type) VALUES ('" + lastName + "', '" + firstName + "', '" + gender + "', '" + race + "', '" + milcon + "', '" + dob + "', '" + ssn + "', '" + church + "', '" + streetAddress + "', '" + apartment + "', '" + city + "', '" + state + "', '" + zip + "', '" + email + "', '" + homephone + "', '" + workPhone + "', '" + mobilePhone + "', '" + type + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        //7)This will save all the Individual at Risk information to the Individual at Risk table from the mataching tab in the PersonsForm.
        public void IndivDataSave(int personId, string teacher, string school, string schoolPhone, string abuse, string neglect)
        {
            sqlConnection1 = InitializeConnectionString();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT IndividualAtRisk (PersonId, School_Name, Teachers_Name, SchoolResource_Number, Abuse, Neglect) VALUES ('" + personId + "', '" + teacher + "', '" + school + "', '" + schoolPhone + "', '" + abuse + "', '" + neglect + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        //8)This will save all the Care Giver information to the Care Giver table from the matching tab in the PersonsForm.
        public void CareGiverSaveData (int personId, int indivId, string relationship)
        {
            sqlConnection1 = InitializeConnectionString();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT CareGiver (PersonId, IndivId, Relationship) VALUES ('" + personId + "', '" + indivId + "', '" + relationship + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        //9)This will save all the Person of Interest information to the Person of Interest table from the matching tab in the PersonsForm.
        public void PersonOfInterestSaveData(int personId, int indivId, string relationship)
        {
            sqlConnection1 = InitializeConnectionString();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT PersonOfInterest (PersonId, IndivId, Relationship) VALUES ('" + personId + "', '" + indivId + "', '" + relationship + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        //10)This will pull the person id for the individual so it can create the individual id in the Individual at Risk table.
        public IndivAtRisk PersonId()
        {
            var indiv = new IndivAtRisk();

            sqlConnection1 = InitializeConnectionString();

            using (sqlConnection1)
            {
                string data = "Select PersonId, Last_Value(PersonId) Over (Partition By PersonId Order By PersonId) from Persons";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);
                sqlConnection1.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        indiv.personId = read["PersonId"].ToString();
                    }
                }
            }
            sqlConnection1.Close();
            return indiv;
        }

        //11)This will pull the individual id in the case so a person of interest id can be created in the person of interest table.
        public PersonOfInterest IndivId()
        {
            var poi = new PersonOfInterest();

            sqlConnection1 = InitializeConnectionString();

            using (sqlConnection1)
            {
                string data = "Select IndivId, Last_Value(IndivId) Over (Partition By IndivId Order By IndivId) from IndividualAtRisk";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);
                sqlConnection1.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        poi.indivId = read["IndivId"].ToString();
                    }
                }
            }
            sqlConnection1.Close();
            return poi;
        }

        //12)This will pull the individual id in the case so a care giver id can be created in the care giver table.
        public CareGiver CareIndivId()
        {
            var care = new CareGiver();

            sqlConnection1 = InitializeConnectionString();

            using (sqlConnection1)
            {
                string data = "Select IndivId, Last_Value(IndivId) Over (Partition By IndivId Order By IndivId) from IndividualAtRisk";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(data, sqlConnection1);
                sqlConnection1.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        care.indivId = read["IndivId"].ToString();
                    }
                }
            }
            sqlConnection1.Close();
            return care;
        }

        //15)This method will allow you to update the Persons table in the database for an existing case in the case view form.
        public void UpdatePersonData(int personId, string lastName, string firstName, string dob, string ssn, string race, string gender, string milcon, string church, string streetAddress, string apartment, string city, string state, string zip, string email, string homephone, string mobilePhone)
        {
            sqlConnection1 = InitializeConnectionString();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Update Persons Set Last_Name = @ln, First_Name = @fn, DOB = @dob, SSN = @ssn, Race = @race, Gender = @gender, Military_Dependent = @mil, Church_Connections = @church, Street_Address = @add, Apartment_Number = @apt, City = @city, State = @state, Zip_Code = @zip, Email = @email, Telephone_Home = @home, Telephone_Mobile = @mobile WHERE Persons.PersonId = '" + personId + "'";

            cmd.Parameters.AddWithValue("@ln", lastName);
            cmd.Parameters.AddWithValue("@fn", firstName);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@ssn", ssn);
            cmd.Parameters.AddWithValue("@race", race);
            cmd.Parameters.AddWithValue("@gender", gender);            
            cmd.Parameters.AddWithValue("@mil", milcon);
            cmd.Parameters.AddWithValue("@church", church);
            cmd.Parameters.AddWithValue("@add", streetAddress);
            cmd.Parameters.AddWithValue("@apt", apartment);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@zip", zip);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@home", homephone);
            cmd.Parameters.AddWithValue("@mobile", mobilePhone);            

            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        //16)This method will allow you to update the IndividualAtRisk table in the database for an existing case in the Individual tab of the case view form.
        public void UpdateIndividualData(int personId, string school, string teacher, string schoolPhone, string abuse, string neglect)
        {
            sqlConnection1 = InitializeConnectionString();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Update IndividualAtRisk Set School_Name = @school, Teachers_Name = @teacher, SchoolResource_Number = @number, Abuse = @abuse, Neglect = @neglect WHERE IndividualAtRisk.PersonId = '" + personId + "'";

            cmd.Parameters.AddWithValue("@school", school);
            cmd.Parameters.AddWithValue("@teacher", teacher);
            cmd.Parameters.AddWithValue("@number", schoolPhone);
            cmd.Parameters.AddWithValue("@abuse", abuse);
            cmd.Parameters.AddWithValue("@neglect", neglect);

            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        //17)This method will allow you to update the Care Giver table in the database for an existing case in the Care Giver tab of the case view form.
        public void UpdateCareGiverData(int personId, string relationship)
        {
            sqlConnection1 = InitializeConnectionString();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Update CareGiver Set Relationship = @relationship WHERE CareGiver.PersonId = '" + personId + "'";

            cmd.Parameters.AddWithValue("@relationship", relationship);            

            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        //18)This method will allow you to update the Person of Interest table in the database for an existing case in the Person of Interest tab of the case view form.
        public void UpdatePOIData(int personId, string relationship)
        {
            sqlConnection1 = InitializeConnectionString();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Update PersonOfInterest Set Relationship = @relationship WHERE PersonOfInterest.PersonId = '" + personId + "'";

            cmd.Parameters.AddWithValue("@relationship", relationship);

            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }  
}