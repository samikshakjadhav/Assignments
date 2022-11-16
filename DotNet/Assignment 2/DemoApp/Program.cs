using bill;

class Program
{
    public static void Main(string[] args)
{
    Patient a = new Patient(101,"XYZ",1, 30);

    InHousePatient b = new InHousePatient(201,"ABC",1, 30, 5);

     Console.WriteLine($"Total Amount Bill of Patient: Rs.{ a.getBillAmount()}");
	 Console.WriteLine("Total Amount Bill Of InhousePatient: Rs.{0:0.00}",b.getBillAmount());
}	        
}
