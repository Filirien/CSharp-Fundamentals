namespace _02.Nature_s_Prophet
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var rows = n[0];
            var cols = n[1];
            var matrix = new int[rows, cols];
            var trueFalseMatrix = new bool[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    trueFalseMatrix[i, k] = false;
                }
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Bloom Bloom Plow")
                {
                    break;
                }
                var line = input.Split(' ').Select(int.Parse).ToList();
                var x = line[0];
                var y = line[1];
                trueFalseMatrix[x, y] = true;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (trueFalseMatrix[i,k] == true)
                    {
                        matrix[i, k]++;
                        for (int indexX = 0; indexX < matrix.GetLength(0); indexX++)
                        {
                            if (indexX== i)
                            {
                                continue;
                            }
                            matrix[indexX, k]++;
                        }
                        for (int indexY = 0; indexY < matrix.GetLength(1); indexY++)
                        {
                            if (indexY == k)
                            {
                                continue;
                            }
                            matrix[i, indexY]++;
                        }
                    }
                }   
            }
           
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    Console.Write(matrix[i,k]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
