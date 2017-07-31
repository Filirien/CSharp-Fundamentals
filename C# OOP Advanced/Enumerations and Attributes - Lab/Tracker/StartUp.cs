using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    [SoftUni("Gosho")]
    public static void Main()
    {
        var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
}


