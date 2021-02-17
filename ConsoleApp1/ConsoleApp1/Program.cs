using System;

namespace EmployeeWageCsharp
{
	public class Program
	{

		public static void Main(String[] args)
		{
			EmpWageBuilder Realiance = new EmpWageBuilder("Realiance", 8000, 50, 250);
			Realiance.ComputeWage();
			Console.WriteLine(Realiance.ToString());
			EmpWageBuilder TATA = new EmpWageBuilder("TATA", 122, 20, 1890);
			TATA.ComputeWage();
			Console.WriteLine(TATA.ToString());
		}
	}
}
