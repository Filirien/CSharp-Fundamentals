namespace _04.Maximal_Sum
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var rows = input[0];
            var cols = input[1];
            var matrix = new int[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new int[cols];
            }
           
            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = currentRow[col];
                }
            }
            var maxSum = int.MinValue;
            var currentSum = -1;
            var maxSumCubeRow = 0;
            var maxSumCubeCol = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                        matrix[row + 1][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                        matrix[row + 2][col] + matrix[row][col + 1] + matrix[row][col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSumCubeRow = row;
                        maxSumCubeCol = col;
                    }
                }
            }
            PrintMaxSumCube(matrix,maxSum,maxSumCubeRow,maxSumCubeCol);
        }

     
        private static void PrintMaxSumCube(int[][] matrix, int maxSum, int maxSumCubeRow, int maxSumCubeCol)
        {
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxSumCubeRow; row <= maxSumCubeRow + 2; row++)
            {
                for (int col = maxSumCubeCol; col <= maxSumCubeCol + 2; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
