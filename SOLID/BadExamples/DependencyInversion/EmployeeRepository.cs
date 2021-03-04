using System;
using System.Linq;

namespace SOLID.BadExamples.DependencyInversion
{
    public class EmployeeRepository
    {
        private DbContext _dbContext;

        public EmployeeRepository()
        {
            _dbContext = new DbContext();
        }

        public Employee GetById(Guid id) => 
            _dbContext.Employees.FirstOrDefault(emp => emp.Id == id);
    }
}
