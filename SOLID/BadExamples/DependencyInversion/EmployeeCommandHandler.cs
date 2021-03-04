using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BadExamples.DependencyInversion
{
    public class EmployeeCommandHandler
    {
        private EmployeeRepository _repository;

        public EmployeeCommandHandler()
        {
            _repository = new EmployeeRepository();
        }

        public double CalculateIncomeTax(Guid id, int year)
        {
            var employee = _repository.GetById(id);

            if (employee != null)
            {
                return 1;
            }

            return 0;
        }
    }
}
