using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            try
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            catch (ArgumentException argumentExcepton)

            {

                Console.WriteLine(argumentExcepton.Message);

            }
        }
        var bonus = double.Parse(Console.ReadLine());

        persons.ForEach(p =>
        {
            p.IncreaseSalary(bonus);
            Console.WriteLine(p);
        });
    }
}
