using System.Collections.Generic;

namespace SOLID.BetterExamples.DependencyInversion
{
    public class DbContext
    {
        public ICollection<Employee> Employees => new List<Employee>();
    }
}
