// See https://aka.ms/new-console-template for more information
using SOLID.App.DependencyInversionGoodAndBad;
using SOLID.App.LiskovSubstitutionPrincipalGood;
using SOLID.App.OpenClosedPrincipalGood2;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");

//SalaryCalculator salaryCalculator = new SalaryCalculator();

//Console.WriteLine($"Low Salary :{ salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"Middle Salary :{ salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
//Console.WriteLine($"High Salary :{ salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");


//Console.WriteLine($"Low Salary :{salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
//Console.WriteLine($"Middle Salary :{salaryCalculator.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
//Console.WriteLine($"High Salary :{salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");

//BasePhone phone = new IPhone();
//phone.Call();
//((ITakePhoto)phone).TakePhoto();

//phone = new Nokia();
//phone.Call();

var productService = new ProductService(new ProductRepositoryFromOracle());

productService.GetAll().ForEach(p => Console.WriteLine(p));
