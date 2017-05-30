namespace _02.SoftUniParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SoftUniParty
    {
        public static void Main()
        {
            var reservationList = new HashSet<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }
                reservationList.Add(input);
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                if (reservationList.Contains(input))
                {
                    reservationList.Remove(input);
                }
            }
            Console.WriteLine(reservationList.Count);
            foreach (var item in reservationList.OrderBy(a=>a))
            {
                Console.WriteLine(item);
            }
        }
    }
}
