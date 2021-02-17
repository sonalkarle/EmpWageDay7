﻿using EmployeeWage;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCsharp
{
    interface InterfaceClass
    {
        public void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        public int ComputeMonthlyWage(CompanyEmpWage company);
        public void DisplayCompanyWages();
    }
}
