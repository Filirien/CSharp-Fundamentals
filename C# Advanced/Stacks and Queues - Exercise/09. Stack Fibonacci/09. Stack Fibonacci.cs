namespace _09.Stack_Fibonacci
{
    using System;
    public class Program
    {
        public static long[] numbers;
        public static void Main()
        {

            var n = int.Parse(Console.ReadLine());
            numbers = new long[n + 1];
            long result = getFibonacci(n - 1);
            Console.WriteLine(result);
        }

        private static long getFibonacci(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            if (numbers[n] != 0)
            {
                return numbers[n];
            }
            numbers[n] = getFibonacci(n - 1) + getFibonacci(n - 2);
            return numbers[n];
        }
    }
}
