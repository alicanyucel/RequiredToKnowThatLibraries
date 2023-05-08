using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App.OpenClosedPrincipalGood
{
    //Good Version
    //I.Way
    public interface ISalaryCalculator
    {
        decimal Calculate(decimal salary);
    }
    public class LowSalaryCalculate : ISalaryCalculator
    {
        public decimal Calculate(decimal salary)
        {
            decimal newSalary = salary * 2;
            return newSalary;
        }
    }    
    public class MiddleSalaryCalculate : ISalaryCalculator
    {
        public decimal Calculate(decimal salary)
        {
            decimal newSalary = salary * 4;
            return newSalary;
        }
    }    
    public class HighSalaryCalculate : ISalaryCalculator
    {
        public decimal Calculate(decimal salary)
        {
            decimal newSalary = salary * 6;
            return newSalary;
        }
    }
    public class ManagerSalaryCalculate : ISalaryCalculator
    {
        public decimal Calculate(decimal salary)
        {
            decimal newSalary = salary * 8;
            return newSalary;
        }
    }

    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary,ISalaryCalculator salaryCalculator)
        {
            return salaryCalculator.Calculate(salary);
        }

    }

}
