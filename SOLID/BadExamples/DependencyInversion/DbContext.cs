using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BadExamples.DependencyInversion
{
    public class DbContext
    {
        public ICollection<Employee> Employees => new List<Employee>();
    }
}
