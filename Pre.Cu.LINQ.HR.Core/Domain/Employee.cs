
using System;

namespace Pre.Cu.LINQ.HR.Core.Domain
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }

        public Employee(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
        }
    }
}
