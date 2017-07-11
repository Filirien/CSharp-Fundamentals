using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        try
        {
            var studentNameFac = Console.ReadLine().Split(' ').ToList();
            var workerNameSalary = Console.ReadLine().Split(' ').ToList();
          

            Student student = new Student(
                studentNameFac[0],
                studentNameFac[1], 
                studentNameFac[2]
                );

            Worker worker = new Worker(
                workerNameSalary[0],
                workerNameSalary[1],
                decimal.Parse(workerNameSalary[2]),
                decimal.Parse(workerNameSalary[3])
                );

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
