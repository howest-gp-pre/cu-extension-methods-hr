using Pre.Cu.LINQ.HR.Reporting.Core;
using Pre.Cu.LINQ.HR.Repository;

namespace Pre.Cu.LINQ.HR.Reporting.Cons;

public class App
{
    public void Run()
    {
        var localDriverRepository = new LocalDriverRepository();

        localDriverRepository.GetAllByNameLike("Jeanette");
    }
}