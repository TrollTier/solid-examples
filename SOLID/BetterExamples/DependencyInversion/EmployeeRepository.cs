using System;
using System.Linq;

namespace SOLID.BetterExamples.DependencyInversion
{
    public class EmployeeRepository
    {
        private DbContext _dbContext;

        public EmployeeRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Employee GetById(Guid id) =>
            _dbContext.Employees.FirstOrDefault(emp => emp.Id == id);
    }
}
