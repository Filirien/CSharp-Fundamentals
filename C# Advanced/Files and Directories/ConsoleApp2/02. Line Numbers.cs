namespace _02._Line_Numbers
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines(@"C:\Users\Niki\Desktop\C# Fundamentals\Exercises\03. CSharp-Advanced-Files-And-Directories\03_LineNumbers\01_LinesIn.txt");
            var counter = 0;
            foreach (var item in text)
            {
                counter++;
                Console.WriteLine($"{counter}. {item}");
            }
        }
    }
}

