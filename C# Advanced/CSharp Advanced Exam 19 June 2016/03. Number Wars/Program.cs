using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayer = new Queue<string>();
            var secondPlayer = new Queue<string>();
            var inputFirst = Console.ReadLine().Split(' ');
            var inputSecond = Console.ReadLine().Split(' ');

            foreach (var item in inputFirst)
            {
                firstPlayer.Enqueue(item);
            }
            foreach (var item in inputSecond)
            {
                secondPlayer.Enqueue(item);
            }
            var rounds=0;
            while (true)
            {
                rounds++;
                if (firstPlayer.Count < 1 || secondPlayer.Count < 1)
                {
                    break;
                }
                var pattern = @"(\d+)([a-z]+)";
                var regex = new Regex(pattern);
                var firstAdd = firstPlayer.Peek();
                var secondAdd = secondPlayer.Peek();

                var patternAlphabet = @"[a-z]";
                var regexAlphabet = new Regex(patternAlphabet);
                var alphabetFirstMatch = regexAlphabet.Match(firstPlayer.Peek());
                var alphabetSecondMatch = regexAlphabet.Match(secondPlayer.Peek());

                var patternDigits = @"\d+";
                var regexDigits = new Regex(patternDigits);
                var firstDigitMatch = regexDigits.Match(firstPlayer.Peek());
                var secondDigitMatch = regexDigits.Match(secondPlayer.Peek());
                if (int.Parse(firstDigitMatch.Groups[1].Value) > int.Parse(secondDigitMatch.Groups[2].Value))
                {
                    firstPlayer.Dequeue();
                    secondPlayer.Dequeue();
                    firstPlayer.Enqueue(firstAdd);
                    firstPlayer.Enqueue(secondAdd);
                }
                else if (int.Parse(firstDigitMatch.Groups[1].Value) < int.Parse(secondDigitMatch.Groups[2].Value))
                {
                    secondPlayer.Enqueue(secondAdd);
                    secondPlayer.Enqueue(firstAdd);
                }
                else
                {
                    continue;
                   //var warWinner = AlphabetSum(firstPlayer,secondPlayer);
                   // if (warWinner)
                   // {

                   // }
                }
            }
            if (firstPlayer.Count>secondPlayer.Count)
            {
                Console.WriteLine($"First player wins after {rounds} turns");
            }
            else if (firstPlayer.Count<secondPlayer.Count)
            {
                Console.WriteLine($"Second player wins after {rounds} turns");

            }
            else
            {
                Console.WriteLine($"Draw after {rounds} turns");

            }

        }

        //private static bool AlphabetSum(Queue<string> firstQueue, Queue<string> secondQueue)
        //{
        //    var lische = new List<string>();
        //    var countOfFirstLetters = 0;
        //    var countOfSecondLetters = 0;
        //    while (true)
        //    {

        //        for (int i = 0; i < listFirst.Count; i++)
        //        {
        //            switch (listFirst[i])
        //            {
        //                case 'a':
        //                    countOfFirstLetters += 1;
        //                    break;
        //                case 'b':
        //                    countOfFirstLetters += 2;
        //                    break;
        //                case 'c':
        //                    countOfFirstLetters += 3;
        //                    break;
        //                case 'd':
        //                    countOfFirstLetters += 4;
        //                    break;
        //                case 'e':
        //                    countOfFirstLetters += 5;
        //                    break;
        //                case 'f':
        //                    countOfFirstLetters += 6;
        //                    break;
        //                case 'g':
        //                    countOfFirstLetters += 7;
        //                    break;
        //                case 'h':
        //                    countOfFirstLetters += 8;
        //                    break;
        //                case 'i':
        //                    countOfFirstLetters += 9;
        //                    break;
        //                case 'j':
        //                    countOfFirstLetters += 10;
        //                    break;
        //                case 'k':
        //                    countOfFirstLetters += 11;
        //                    break;
        //                case 'l':
        //                    countOfFirstLetters += 12;
        //                    break;
        //                case 'm':
        //                    countOfFirstLetters += 13;
        //                    break;
        //                case 'n':
        //                    countOfFirstLetters += 14;
        //                    break;
        //                case 'o':
        //                    countOfFirstLetters += 15;
        //                    break;
        //                case 'p':
        //                    countOfFirstLetters += 16;
        //                    break;
        //                case 'q':
        //                    countOfFirstLetters += 17;
        //                    break;
        //                case 'r':
        //                    countOfFirstLetters += 18;
        //                    break;
        //                case 's':
        //                    countOfFirstLetters += 19;
        //                    break;
        //                case 't':
        //                    countOfFirstLetters += 21;
        //                    break;
        //                case 'u':
        //                    countOfFirstLetters += 22;
        //                    break;
        //                case 'v':
        //                    countOfFirstLetters += 23;
        //                    break;
        //                case 'w':
        //                    countOfFirstLetters += 24;
        //                    break;
        //                case 'x':
        //                    countOfFirstLetters += 25;
        //                    break;
        //                case 'y':
        //                    countOfFirstLetters += 26;
        //                    break;
        //                case 'z':
        //                    countOfFirstLetters += 27;
        //                    break;

        //            }
        //        }
        //        for (int i = 0; i < listSecond.Count; i++)
        //        {
        //            switch (listSecond[i])
        //            {
        //                case 'a':
        //                    countOfSecondLetters += 1;
        //                    break;
        //                case 'b':
        //                    countOfSecondLetters += 2;
        //                    break;
        //                case 'c':
        //                    countOfSecondLetters += 3;
        //                    break;
        //                case 'd':
        //                    countOfSecondLetters += 4;
        //                    break;
        //                case 'e':
        //                    countOfSecondLetters += 5;
        //                    break;
        //                case 'f':
        //                    countOfSecondLetters += 6;
        //                    break;
        //                case 'g':
        //                    countOfSecondLetters += 7;
        //                    break;
        //                case 'h':
        //                    countOfSecondLetters += 8;
        //                    break;
        //                case 'i':
        //                    countOfSecondLetters += 9;
        //                    break;
        //                case 'j':
        //                    countOfSecondLetters += 10;
        //                    break;
        //                case 'k':
        //                    countOfSecondLetters += 11;
        //                    break;
        //                case 'l':
        //                    countOfSecondLetters += 12;
        //                    break;
        //                case 'm':
        //                    countOfSecondLetters += 13;
        //                    break;
        //                case 'n':
        //                    countOfSecondLetters += 14;
        //                    break;
        //                case 'o':
        //                    countOfSecondLetters += 15;
        //                    break;
        //                case 'p':
        //                    countOfSecondLetters += 16;
        //                    break;
        //                case 'q':
        //                    countOfSecondLetters += 17;
        //                    break;
        //                case 'r':
        //                    countOfSecondLetters += 18;
        //                    break;
        //                case 's':
        //                    countOfSecondLetters += 19;
        //                    break;
        //                case 't':
        //                    countOfSecondLetters += 21;
        //                    break;
        //                case 'u':
        //                    countOfSecondLetters += 22;
        //                    break;
        //                case 'v':
        //                    countOfSecondLetters += 23;
        //                    break;
        //                case 'w':
        //                    countOfSecondLetters += 24;
        //                    break;
        //                case 'x':
        //                    countOfSecondLetters += 25;
        //                    break;
        //                case 'y':
        //                    countOfSecondLetters += 26;
        //                    break;
        //                case 'z':
        //                    countOfSecondLetters += 27;
        //                    break;
        //            }
        //        }
        //    }
        //    if (countOfFirstLetters > countOfSecondLetters)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
