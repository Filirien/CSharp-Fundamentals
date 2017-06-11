namespace _05.Concatenate_Strings
{
    using System;
    using System.Text;
    public class Program
    {
        public static void Main()
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());

            StringBuilder resultText = new StringBuilder();
            for (int i = 0; i < numberOfInputLines; i++)
            {
                resultText.Append(Console.ReadLine() + " ");
            }

            Console.WriteLine(resultText);
        }
    }
}
