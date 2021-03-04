using System;

namespace SOLID.BadExamples.InterfaceSegregation
{
    public interface IEmployeeManager
    {
        public double CalculateTaxes(Employee employee);
        public Employee GetFromDatabase(Guid id);
        public void ChangeDepartment(Employee employee, Guid newDepartmentId);
        public EmployeeListModel ToListModel(Employee entity);
    }
}
