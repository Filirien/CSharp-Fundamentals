﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        var spy = new Spy();
        string result = spy.RevealPrivateMethods("Hacker");
        Console.WriteLine(result);
    }
}
