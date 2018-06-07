using System;

public class IndivAtRisk : Person
{
    private int _indivID; //auto generated PK from DB table: indivAtRisk
    private string _schoolName;
    private string _teacherName;
    private string _schoolTelephone;
    private bool _abuse;
    private bool _neglect;

    //Constructor
	public IndivAtRisk(int indivID, int personID, string lastName, string firstName, DateTime dateOfBirth,
        string socialSecurityNumber, string streetAddress, string apartment,
        string city, int zip, string email, string tel1, string tel2, string tel3,
        string demographic, string faithConnection, bool military, string schoolName, string teacherName,
        string schoolTelephone, bool abuse, bool neglect) : base (personID, lastName,  firstName,  dateOfBirth,
            socialSecurityNumber, streetAddress, apartment, city, zip,  email, tel1,  tel2,tel3, demographic,
            faithConnection, military)
	{
        IndivID = _indivID; 
        SchoolName = _schoolName;
        TeacherName = _teacherName;
        SchoolTelephone = _schoolTelephone;
        Abuse = _abuse;
        Neglect = _neglect;        
    }

    //setters and getters
    public int IndivID { get => _indivID; }//no setter
    public string SchoolName { get => _schoolName; set => _schoolName = value; }
    public string TeacherName { get => _teacherName; set => _teacherName = value; }
    public string SchoolTelephone { get => _schoolTelephone; set => _schoolTelephone = value; }
    public bool Abuse { get => _abuse; set => _abuse = value; }
    public bool Neglect { get => _neglect; set => _neglect = value; }
}
