using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string investigatedClass,params string[] requestedFields)
    {
        var classType = Type.GetType(investigatedClass);
        var classFields = classType.GetFields(BindingFlags.Instance|BindingFlags.Static|BindingFlags.Public|BindingFlags.NonPublic);
       var stringBuilder = new StringBuilder();
        var classInstance = Activator.CreateInstance(classType, new object[] { });
        stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");
        foreach (var field in classFields.Where(f=>requestedFields.Contains(f.Name)))
        {
            stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }
        return stringBuilder.ToString().Trim();
    }
}
