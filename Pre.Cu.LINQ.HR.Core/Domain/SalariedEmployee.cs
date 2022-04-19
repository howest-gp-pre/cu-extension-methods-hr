
using System;

namespace Pre.Cu.LINQ.HR.Core.Domain
{
    public class SalariedEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }

        public SalariedEmployee(string firstName, string lastName, DateTime dob, decimal monthlySalary) : base(
            firstName, lastName, dob)
        {
            MonthlySalary = monthlySalary;
        }
    }
}
