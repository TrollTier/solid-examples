using System;

namespace SOLID.BadExamples.DependencyInversion
{
    public class Employee
    {
        public Guid Id { get; set; }
        public int PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
