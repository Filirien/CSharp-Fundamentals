using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        var cirle = new Circle(5);
        Console.WriteLine(cirle.CalculateArea());
        Console.WriteLine(cirle.CalculatePerimeter());
        Console.WriteLine(cirle.Draw());

    }
}
