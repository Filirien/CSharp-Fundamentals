namespace _01.ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var parking = new HashSet<string>();
            while (input != "END")
            {
               var result = Regex.Split(input, ", ");
                if (result[0] == "IN")
                {
                    parking.Add(result[1]);
                }
                else
                {
                    parking.Remove(result[1]);
                }
                input = Console.ReadLine();
            }
            var list = new SortedDictionary<string,string>();
            if (parking.Count!=0)
            {
                foreach (var item in parking    )
                {
                    list[item] = item;
                }
                foreach (var item in list)
                {
                    Console.WriteLine(item.Key);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
