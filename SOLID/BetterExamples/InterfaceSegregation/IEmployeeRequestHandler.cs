namespace SOLID.BetterExamples.InterfaceSegregation
{
    public interface IEmployeeRequestHandler
    {
        public EmployeeListModel ToListModel(Employee entity);
    }
}
