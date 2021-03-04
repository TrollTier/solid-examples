using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BetterExamples.InterfaceSegregation
{
    public interface IEmployeeCommandHandler
    {
        public double CalculateTaxes(Employee employee);
        public void ChangeDepartment(Employee employee, Guid newDepartmentId);
    }
}
