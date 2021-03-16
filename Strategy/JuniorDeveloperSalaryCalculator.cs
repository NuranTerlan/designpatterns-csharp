using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class JuniorDeveloperSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) =>
            reports.Where(r => r.Level == DeveloperLevel.Junior)
                .Select(r => r.CalculateSalary())
                .Sum();
    }
}