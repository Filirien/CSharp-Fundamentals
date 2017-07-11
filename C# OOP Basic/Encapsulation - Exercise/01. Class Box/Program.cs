using System;
using System.Linq;
using System.Reflection;

public class Program
{
    public static void Main()
    {

        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());
        var l = double.Parse(Console.ReadLine());
        var w = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
        var surface = 2*w*l + 2*l*h + 2*w*h;
        var lateral = 2*l*h + 2*w*h;
        var volume = w * l * h;
        Console.WriteLine($"Surface Area - {surface:f2}");
        Console.WriteLine($"Lateral Surface Area - {lateral:f2}");
        Console.WriteLine($"Volume - {volume:f2}");
    }
}
