using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App.OpenClosedPrincipalGood2
{
    //Good Version
    //II.Way
    //Built-in Delegate in C# Action=> void, Predicate =>bool,Function

    public class LowSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            decimal newSalary = salary * 2;
            return newSalary;
        }
    }
    public class MiddleSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            decimal newSalary = salary * 4;
            return newSalary;
        }
    }
    public class HighSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            decimal newSalary = salary * 6;
            return newSalary;
        }
    }
    public class ManagerSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            decimal newSalary = salary * 8;
            return newSalary;
        }
    }
    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary,Func<decimal,decimal> calculate)
        {
            return calculate(salary);
        }


    }

    

}
