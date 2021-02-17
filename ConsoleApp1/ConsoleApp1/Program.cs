using System;

namespace EmployeeWage
{
	public class Program
	{
		public static void Main(String[] args)
		{
			EmpWageBuilder empWageBuilder = new EmpWageBuilder();
			empWageBuilder.AddCompany("Relaince", 4000, 84, 258);
			empWageBuilder.AddCompany("Godrej", 940, 80, 240);
			empWageBuilder.AddCompany("Google", 250, 90, 850);
			empWageBuilder.AddCompany("TATA", 8000, 50, 200);
			empWageBuilder.DisplayCompanyMonthlyWages();
			empWageBuilder.DisplayCompanyDailyWages();
			Console.WriteLine($"Monthly Wages for Google are {empWageBuilder.GetMonthlyWageByCompanyName("Google")} ");
		}
	}
}
