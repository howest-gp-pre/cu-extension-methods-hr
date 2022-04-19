using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Pre.Cu.LINQ.HR.Core.Domain;
using Pre.Cu.LINQ.HR.Repository;

namespace Pre.Cu.LINQ.HR.Reporting.Core
{
    public static class LocalDriverRepositoryExtensions
    {
        public static IEnumerable<Driver> GetAllByNameLike(this LocalDriverRepository localDriverRepository, string name)
        {
            return localDriverRepository.GetAll().Where(driver => driver.FullName.Contains(name));
        }

        public static IEnumerable<Driver> GetAllByLicense(this LocalDriverRepository localDriverRepository,
            DriversLicense license)
        {
            return localDriverRepository.GetAll().Where(driver => driver.Licenses.Contains(license));
        }

        private static int CalculateAge(Driver driver)
        {
            var age = DateTime.Now.Year - driver.Dob.Year;  
            if (DateTime.Now.DayOfYear < driver.Dob.DayOfYear)  
                age = age - 1;

            return age;
        }
        
        public static Driver GetOldest(this LocalDriverRepository localDriverRepository)
        {
            var maxAge= localDriverRepository.GetAll().Max(CalculateAge);
            return localDriverRepository.GetAll().SingleOrDefault(driver => driver.Dob.Year == maxAge);
        }

        public static IEnumerable<Driver> GetWithWageHigherThan(this LocalDriverRepository localDriverRepository, decimal wage)
        {
            return localDriverRepository.GetAll().Where(driver => driver.Wage > wage);
        }

        
    }
}