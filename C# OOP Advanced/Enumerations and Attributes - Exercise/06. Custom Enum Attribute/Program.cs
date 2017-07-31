using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        string inputCategory = Console.ReadLine();

      var customAttributes = typeof(CardRanks).GetCustomAttributes(false)
          .Union(typeof(Suits).GetCustomAttributes(false))
          .Where(ca => ca.GetType() == typeof(TypeAttribute));

      foreach (TypeAttribute customAttribute in customAttributes)
      {
          if (customAttribute.Category == inputCategory)
          {
              Console.WriteLine(customAttribute);
              break;
          }
      }
    }
}
