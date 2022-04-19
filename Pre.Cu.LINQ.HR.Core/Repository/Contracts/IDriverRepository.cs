using System.Linq;
using Pre.Cu.LINQ.HR.Core.Domain;

namespace Pre.Cu.LINQ.HR.Repository
{
    public interface IDriverRepository
    {
        IQueryable<Driver> GetAll();
    }
}
