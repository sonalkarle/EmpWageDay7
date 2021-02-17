﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    interface IComputeEmpWage
    {
        public void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        public int ComputeMonthlyWage(CompanyEmpWage company);
        public void DisplayCompanyWages();
    }
}
