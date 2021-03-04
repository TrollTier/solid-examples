using System;

namespace SOLID.BetterExamples.DependencyInversion
{
    public class EmployeeCommandHandler
    {
        private EmployeeRepository _repository;

        public EmployeeCommandHandler(EmployeeRepository repository)
        {
            _repository = repository;
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
