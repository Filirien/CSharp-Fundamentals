namespace _03.Squares_in_Matrix
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
            var matrix = new string[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new string[cols];
            }
            var leftSum = 0;
            var rightSum = 0;

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = currentRow[col];
                }
            }

            var counter = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (IsEquals(row, col, matrix))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        private static bool IsEquals(int row, int col, string[][] matrix)
        {
            return matrix[row][col] == matrix[row][col + 1] &&
                matrix[row][col+1] == matrix[row + 1][col] &&
                matrix[row+1][col] == matrix[row + 1][col + 1];
        }
    }
}
