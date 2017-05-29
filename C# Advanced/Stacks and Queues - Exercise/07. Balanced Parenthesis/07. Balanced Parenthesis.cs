namespace _07.Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            var stack = new Stack<char>();

            var input = Console.ReadLine().ToCharArray();



            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                switch (currentChar)
                {
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '(':
                        stack.Push(')');
                        break;
                    default:
                        if (currentChar != stack.Pop())
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
