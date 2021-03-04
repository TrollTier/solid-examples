using System;

namespace SOLID.BetterExamples.OpenClosed
{
    public class Employee
    {
        private IEmployeeSerializer _serializer;

        public Guid Id { get; set; }
        public int PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(IEmployeeSerializer serializer)
        {
            _serializer = serializer;
        }

        public string Serialize()
        {
            return _serializer.Serialize(this);
        }
    }
}
