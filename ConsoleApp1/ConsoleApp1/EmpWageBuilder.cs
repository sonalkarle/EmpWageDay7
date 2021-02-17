using System;
using System.Text;

namespace EmployeeWageCsharp
{
	class EmpWageBuilder
	{
		//Constant
		const int FULL_DAY_HOUR = 8;
		const int PART_TIME_HOUR = 4;
		const int EMP_FULL_TIME = 1;
		const int EMP_PART_TIME = 2;
	    string companyName;
		int wagePerHour;
		int maxWorkingDays;
		int maxWorkingHours;
		int wagesPerMonth = 0;
		public EmpWageBuilder(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
		{
			//Variable
			this.companyName = companyName;
			this.wagePerHour = wagePerHour;
			this.maxWorkingDays = maxWorkingDays;
			this.maxWorkingHours = maxWorkingHours;
		}
		public void ComputeWage()
		{
			int workingHours = 0;
			int workingDays = 0;
			
			// Computation

			Random rand = new Random();

			while (workingHours < maxWorkingHours && workingDays < maxWorkingDays) 
			{
				int attendance = rand.Next(0, 3);
				int hoursWorked = 0;
				switch (attendance)
				{
					case EMP_FULL_TIME:
						workingDays = workingDays + 1;
						hoursWorked = FULL_DAY_HOUR;
						break;
					case EMP_PART_TIME:
						workingDays = workingDays + 1;
						hoursWorked = PART_TIME_HOUR;
						break;
					default:
						break;
				}

				workingHours += hoursWorked;
				wagesPerMonth += (wagePerHour * workingHours);

			}

		}
		//Inheritance variable
		public override string ToString()
		{
			return $"Wages for the company {companyName} for the month : {wagesPerMonth}";
		}
	}
}