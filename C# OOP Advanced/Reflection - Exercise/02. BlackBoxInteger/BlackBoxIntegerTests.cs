using System;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using _02.BlackBoxInteger.Models;

namespace _02.BlackBoxInteger
{
   public class BlackBoxIntegerTests
    {
        private const BindingFlags NonPublicFlags = BindingFlags.Instance|BindingFlags.NonPublic;
        public static void Main()
        {
            var type = typeof(BlackBoxInt);
            var myBlackBox = (BlackBoxInt)Activator.CreateInstance(type,true);
            var field = type.GetField("innerValue");
            string inputLine;
            while ((inputLine=Console.ReadLine())!="END")
            {
                var tokens = inputLine.Split('_');
                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                type.GetMethod(methodName, NonPublicFlags).Invoke(myBlackBox, new object[] {value});

                object innerStateValue = type
                    .GetFields(NonPublicFlags)
                    .First()
                    .GetValue(myBlackBox);
                Console.WriteLine(innerStateValue);


            }
        }
    }
}
