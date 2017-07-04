using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var people = new List<Employee>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            Employee emp;
            if (input.Count == 4)
            {
                emp = new Employee(input[0], double.Parse(input[1]), input[2], input[3]);
            }
            else if (input.Count == 5)
            {
                int num;
                bool isNum = int.TryParse(input[4], out num);
                if (isNum)
                {
                    emp = new Employee(input[0], double.Parse(input[1]), input[2], input[3], num);
                }
                else
                {
                    emp = new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4]);
                }
            }
            else
            {
                int num;
                bool isNum = int.TryParse(input[4], out num);
                if (isNum)
                {
                    emp = new Employee(input[0], double.Parse(input[1]), input[2], input[3], num, input[5]);

                }
                else
                {
                    emp = new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[5], num);

                }
            }
            people.Add(emp);
        }
        var highestDeparment = people.GroupBy(x => x.Department)
            .Select(e => new
            {
                Department = e.Key,
                AverageSalary = e.Average(s => s.Salary),
                Employees = e.OrderByDescending(s => s.Salary)
            })
            .OrderByDescending(e => e.AverageSalary);
        var maxAverageSalaryDepartment = highestDeparment.FirstOrDefault();
        Console.WriteLine($"Hightest Average Salary: {maxAverageSalaryDepartment.Department}");
        foreach (var item in maxAverageSalaryDepartment.Employees)
        {
            Console.WriteLine(item);
        }
    }
}
