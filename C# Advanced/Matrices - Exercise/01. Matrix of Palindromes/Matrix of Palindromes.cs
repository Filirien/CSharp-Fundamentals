namespace _01.Matrix_of_Palindromes
{
    using System;
    using System.Linq;
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = input[0];
            var cols = input[1];
            string[][] matrix = new string[rows][];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new string[cols];
            }

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (int colsIndex = 0; colsIndex < cols; colsIndex++)
                {
                    Console.Write(""+alphabet[rowIndex] + alphabet[colsIndex+rowIndex] + alphabet[rowIndex]);
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
}
