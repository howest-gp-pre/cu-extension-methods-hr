using System;
using System.Collections.Generic;
using System.Linq;
using Pre.Cu.LINQ.HR.Core.Domain;

namespace Pre.Cu.LINQ.HR.Repository
{
    public class LocalDriverRepository: IDriverRepository
    {
        private ICollection<Driver> drivers = new List<Driver>();

        public LocalDriverRepository()
        {
            GenerateMockData();
        }

        private void GenerateMockData()
        {
            drivers = new List<Driver>();

            drivers.Add(new Driver("Jeanette", "Roberts", new DateTime(1960,4,16), 12.75M, 40).AddLicenseInternal(DriversLicense.B).AddLicenseInternal(DriversLicense.C));
            drivers.Add(new Driver("Stanley", "White", new DateTime(1970,2,5),12.5M,20).AddLicenseInternal(DriversLicense.C).AddLicenseInternal(DriversLicense.D));
            drivers.Add(new Driver("Jeannie", "Mericle",new DateTime(1992,11,23),14M,38).AddLicenseInternal(DriversLicense.C).AddLicenseInternal(DriversLicense.G));
            drivers.Add(new Driver("James", "Villarreal",new DateTime(1982,3,4),12.6M,40).AddLicenseInternal(DriversLicense.C));
            drivers.Add(new Driver("Miguel", "Jackson",new DateTime(1969,10,3),12.9M,32).AddLicenseInternal(DriversLicense.C));
            drivers.Add(new Driver("Raymond", "Lopesz", new DateTime(1986, 4,28), 13.2M,40).AddLicenseInternal(DriversLicense.C));
            drivers.Add(new Driver("Robert", "Wall", new DateTime(1978,2,16),13.6M,40).AddLicenseInternal(DriversLicense.C));
            drivers.Add(new Driver("Pamela", "Shores", new DateTime(1989,8,10),15.8M,40).AddLicenseInternal(DriversLicense.C));
            drivers.Add(new Driver("Vernita", "Roberts", new DateTime(1971,5,8),11.2M,20).AddLicenseInternal(DriversLicense.AM).AddLicenseInternal(DriversLicense.G));
            drivers.Add(new Driver("Jennifer", "Ortiz", new DateTime(1954,9,5),12.75M,40).AddLicenseInternal(DriversLicense.C));
        }

        public IQueryable<Driver> GetAll()
        {
            return drivers.AsQueryable();
        }
    }
}
