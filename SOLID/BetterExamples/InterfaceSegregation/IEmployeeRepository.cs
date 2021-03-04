using System;

namespace SOLID.BetterExamples.InterfaceSegregation
{
    public interface IEmployeeRepository
    {
        Employee GetById(Guid id);
    }
}
