using System;

namespace DesignPatterns
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumMain { get; set; }
        public string PhoneNumBackup { get; set; }
        public Positions Position { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"\n*************\nId: {Id}\n{FirstName} {LastName}, {Age}\n" +
                   $"Email: {Email}\nMain phone number: {PhoneNumMain} | Backup: {PhoneNumBackup}\n" +
                   $"Position: {Position}\nSalary: ${Salary}\n*************\\n";
        }
    }
}