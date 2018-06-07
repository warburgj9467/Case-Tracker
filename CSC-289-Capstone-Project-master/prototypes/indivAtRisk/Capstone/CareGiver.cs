using System;

public class CareGiver : Person
{
    //private fields
    private int _careGiverID;  //auto generated PK from DB table: careGiver
    // private int _indivID;  //from indivAtRisk class?  how does that work?
    private string _relationship;

    public CareGiver()
	{
	}
}
