using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}