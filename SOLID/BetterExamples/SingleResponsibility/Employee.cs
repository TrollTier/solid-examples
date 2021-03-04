using System;

namespace SOLID.BetterExamples.SingleResponsibility
{
    public class Employee
    {
        public Guid Id { get; set; }
        public int PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
