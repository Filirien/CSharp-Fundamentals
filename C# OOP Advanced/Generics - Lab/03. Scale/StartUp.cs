using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        Scale<int> ints = new Scale<int>(20, 15);
        System.Console.WriteLine(ints.GetHavier());
    }
}
