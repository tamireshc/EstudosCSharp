using System.Globalization;
using System.Linq;
using LinqLambda.Entities;

string path = "/Users/tamireshc/Desktop/linq-lambda/in.csv";
List<Employee> listEmployee = new List<Employee>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(",");
            var employee = new Employee(line[0], line[1], double.Parse(line[2], CultureInfo.InvariantCulture));
            listEmployee.Add(employee);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}

Console.WriteLine("Give a value for a salary");
double salaryValue = double.Parse(Console.ReadLine());

var employeeEmailsWithSalaryIsOverSalaryValue = listEmployee.Where(e => e.Salary > salaryValue)
.Select(e => e.Email)
.Order();

Console.WriteLine($"Email of people whose salary is more than {salaryValue}");
foreach (var employee in employeeEmailsWithSalaryIsOverSalaryValue)
{
    Console.WriteLine(employee);
}

var sumOfSalaryEmployeeWithNameStartsWithM = listEmployee.Where(e => e.Name[0] == 'M')
.Select(e => e.Salary)
.Sum();
Console.Write($"Sum of salary of people whose name starts with 'M': {sumOfSalaryEmployeeWithNameStartsWithM:F2}");
