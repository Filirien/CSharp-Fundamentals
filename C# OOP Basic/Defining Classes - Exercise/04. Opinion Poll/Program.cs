using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var list = new List<Person>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            var person = new Person(name, age);
            if (person.Age>30)
            {
                list.Add(person);
            }
        }
        
        foreach (var item in list.OrderBy(x=>x.Name))
        {
            Console.WriteLine(item);
        }

    }
}
