using Pre.Cu.LINQ.HR.Reporting.Core;
using Pre.Cu.LINQ.HR.Repository;

namespace Pre.Cu.LINQ.HR.Reporting.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            var localDriverRepository = new LocalDriverRepository();

            localDriverRepository.GetAllByNameLike("Jeanette");
        }
    }
}
