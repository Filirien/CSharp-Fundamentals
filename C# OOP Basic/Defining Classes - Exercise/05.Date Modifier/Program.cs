using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd",
                                        System.Globalization.CultureInfo.InvariantCulture);
        var startEnd = new DateModifier();
        startEnd.StartingDate = startDate;
        startEnd.EndDate = endDate;

        var result = Math.Abs((startEnd.EndDate - startEnd.StartingDate).TotalDays);
        Console.WriteLine(result);
    }
}

