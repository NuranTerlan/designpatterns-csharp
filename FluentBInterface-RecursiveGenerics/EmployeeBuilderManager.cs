namespace DesignPatterns
{
    public class EmployeeBuilderManager : EmployeeJobBuilder<EmployeeBuilderManager>
    {
        public static EmployeeBuilderManager NewEmployee => new EmployeeBuilderManager();
    }
}