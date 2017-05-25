namespace _01._Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main()
        {
           string[] text = File.ReadAllLines(@"C:\Users\Niki\Desktop\C# Fundamentals\Exercises\03. CSharp-Advanced-Files-And-Directories\02_OddLines\02_OddLinesIn.txt");
            var counter = 0;
            foreach (var item in text)
            {
                if (counter%2==1)
                {
                    Console.WriteLine(item);
                }
                counter++;
            }
        }
    }
}
