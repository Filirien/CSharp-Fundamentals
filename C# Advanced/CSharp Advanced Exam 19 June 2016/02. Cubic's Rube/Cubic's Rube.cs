namespace _02.Cubic_s_Rube
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class CubicsRube
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int[,,] cube = new int[n, n, n];
            long sum = 0;
            var count = 0;
            var x = 0;
            var y = 0;
            var z = 0;
            var num = 0;
            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                if (line[0] == "Analyze")
                {
                    break;
                }
                x = int.Parse(line[0]);
                y = int.Parse(line[1]);
                z = int.Parse(line[2]);
                num = int.Parse(line[3]);
                if (x <0 || y<0 ||z<0)
                {
                    continue;
                }
                cube[x, y, z] = num;
            }
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int p = 0; p < n; p++)
                    {
                        if (cube[i,k,p] != 0)
                        {
                            sum += cube[i, k, p];
                        }
                        else
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
        }
    }
}
