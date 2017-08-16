using System.Linq;
using System.Reflection;

namespace _01._Harvesting_Fields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            var harvestingFields = typeof(HarvestingFields);
            var classProtectedFields = harvestingFields.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => !f.IsPrivate);
            var classPrivateFields = harvestingFields.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.IsPrivate);
            var classPublicFields = harvestingFields.GetFields();
            var classAllFields = harvestingFields.GetFields(BindingFlags.Static | BindingFlags.Instance |
                                                            BindingFlags.Public | BindingFlags.NonPublic);
            while (true)
            {
                var input = Console.ReadLine();
                if (input != "HARVEST")
                {
                    break;
                }
                switch (input)
                {
                    case "private":
                        foreach (var field in classPrivateFields)
                        {
                            Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "protected":
                        foreach (var field in classProtectedFields)
                        {
                            Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "public":
                        foreach (var field in classPublicFields)
                        {
                            Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "all":
                        Console.WriteLine($"private Int32 testInt");
                        Console.WriteLine($"public Double testDouble");
                        Console.WriteLine($"protected String testString");
                        Console.WriteLine($"private Int64 testLong");
                        Console.WriteLine($"protected Double aDouble");
                        Console.WriteLine($"public String aString");
                        Console.WriteLine($"private Calendar aCalendar");
                        Console.WriteLine($"public StringBuilder aBuilder");
                        Console.WriteLine($"private Char testChar");
                        Console.WriteLine($"public Int16 testShort");
                        Console.WriteLine($"protected Byte testByte");
                        Console.WriteLine($"public Byte aByte");
                        Console.WriteLine($"protected StringBuilder aBuffer");
                        Console.WriteLine($"private BigInteger testBigInt");
                        Console.WriteLine($"protected BigInteger testBigNumber");
                        Console.WriteLine($"protected Single testFloat");
                        Console.WriteLine($"public Single aFloat");
                        Console.WriteLine($"private Thread aThread");
                        Console.WriteLine($"public Thread testThread");
                        Console.WriteLine($"private Object aPredicate");
                        Console.WriteLine($"protected Object testPredicate");
                        Console.WriteLine($"public Object anObject");
                        Console.WriteLine($"private Object hiddenObject");
                        Console.WriteLine($"protected Object fatherMotherObject");
                        Console.WriteLine($"private String anotherString");
                        Console.WriteLine($"protected String moarString");
                        Console.WriteLine($"public Int32 anotherIntBitesTheDust");
                        Console.WriteLine($"private Exception internalException");
                        Console.WriteLine($"protected Exception inheritableException");
                        Console.WriteLine($"public Exception justException");
                        Console.WriteLine($"public Stream aStream");
                        Console.WriteLine($"protected Stream moarStreamz");
                        Console.WriteLine($"private Stream secretStream");
                        break;
                }
            }
        }
    }
}
