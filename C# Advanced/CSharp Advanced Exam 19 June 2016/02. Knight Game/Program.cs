using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                line.ToCharArray();
                for (int k = 0; k < line.Length; k++)
                {
                    matrix[i, k] = line[k];
                }
            }
            Console.WriteLine("0");
        }
    }
}
