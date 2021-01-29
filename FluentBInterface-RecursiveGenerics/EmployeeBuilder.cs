using System;

namespace DesignPatterns
{
    public abstract class EmployeeBuilder
    {
        protected Employee Employee;

        protected EmployeeBuilder()
        {
            Employee = new Employee
            {
                Id = Guid.NewGuid()
            };
        }

        public Employee Build() => Employee;
    }
}