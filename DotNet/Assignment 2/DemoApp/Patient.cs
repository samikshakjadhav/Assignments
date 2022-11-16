namespace bill;

public class Patient
{
    private int patientId;
    private string patientName;
    private int  bedType;
    private int nod;

    public Patient (int id, string name, int btype, int days)
    {
        patientId = id;
        patientName = name;
        bedType = btype;
        nod = days;
    }

    public int PatientId {get; set;}
    public string PatientName {get; set;}
    public int BedType {get; set;}
    public int Nod {get; set;}

    public virtual double getBillAmount()
    {
			double amount = 0;
		
		if (bedType == 1)
			amount = nod * 500;
		if (bedType == 2)
			amount = nod* 350;
		if (bedType == 3)
			amount = nod * 200;		
		return amount; 
	}



}
