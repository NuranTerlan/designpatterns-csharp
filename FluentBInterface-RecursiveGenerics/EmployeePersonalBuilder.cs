namespace DesignPatterns
{
    public class EmployeePersonalBuilder<T> : EmployeeBuilder where T: EmployeePersonalBuilder<T>
    {
        public T WithFirstName(string firstName)
        {
            Employee.FirstName = firstName;
            return (T) this;
        }

        public T WithLastName(string lastName)
        {
            Employee.LastName = lastName;
            return (T) this;
        }

        public T WithAge(short age)
        {
            Employee.Age = age;
            return (T) this;
        }
    }
}