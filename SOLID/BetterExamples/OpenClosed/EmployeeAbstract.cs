using System;

namespace SOLID.BetterExamples.OpenClosed
{
    public abstract class EmployeeAbstract
    {
        public Guid Id { get; set; }
        public int PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract string Serialize();
    }
}
