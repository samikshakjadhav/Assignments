namespace bill;

public class InHousePatient : Patient 
{
	private float discount;

	public InHousePatient (int id, string name, int btype, int days, float disc) : base(id,  name,  btype, days)
	{	
        discount = disc;
	}
	public double Discount { get; set;}
	public override double getBillAmount() {
		 double amt=0;	
		 amt  = base.getBillAmount();
		 if (amt> 5000){
			 return amt - amt * (discount /100);
		  }
		 else {
			 return amt - amt * 0.05;
		 }	 
	}

}