
using System;

namespace Pre.Cu.LINQ.HR.Core.Domain
{
    public class Driver : Employee
    {
        public decimal Wage { get; set; }
        public int Hours { get; set; }
        public DriversLicense[] Licenses { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public Driver(string firstName, string lastName, DateTime dob, decimal wage, int hours) : base(firstName,
            lastName, dob)
        {
            Licenses = new DriversLicense[Enum.GetNames(typeof(DriversLicense)).Length];
            Wage = wage;
            Hours = hours;
        }

        public void AddLicense(DriversLicense driversLicense)
        {
            Licenses[(int)driversLicense] = driversLicense;
        }
        internal Driver AddLicenseInternal(DriversLicense driversLicense)
        {
            Licenses[(int)driversLicense] = driversLicense;
            return this;
        }
    }
}
