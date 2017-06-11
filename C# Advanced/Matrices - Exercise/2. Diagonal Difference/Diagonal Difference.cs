namespace _2.Diagonal_Difference
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var rows = input;
            var cols = input;
            var matrix = new int[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new int[cols];
            }
            var leftSum = 0;
            var rightSum = 0;

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
            var leftDiagonal = 0;
            for (int row = 0; row < rows; row++)
            {
                leftDiagonal += matrix[row][row];
            }
            var rightDiagonal = 0;
            for (int row = 0; row < rows; row++)
            {
                rightDiagonal += matrix[row][cols-row-1];
            }
            var result = leftDiagonal - rightDiagonal;
            Console.WriteLine(Math.Abs(result));
        }
    }
}
