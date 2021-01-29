namespace DesignPatterns
{
    public class EmployeeJobBuilder<T> : EmployeeContactBuilder<EmployeeJobBuilder<T>> where T: EmployeeJobBuilder<T>
    {
        public T AtPosition(Positions position)
        {
            Employee.Position = position;
            return (T) this;
        }

        public T WithSalary(decimal salaryAmount)
        {
            Employee.Salary = salaryAmount;
            return (T) this;
        }
    }
}