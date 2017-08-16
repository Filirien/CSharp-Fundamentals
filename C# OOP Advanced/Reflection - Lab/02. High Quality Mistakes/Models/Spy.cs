using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string AnalyzeAcessModifiers(string investigatedClass)
    {
        var classType = Type.GetType(investigatedClass);
        var classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static| BindingFlags.Public);
        var classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        var classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        var stringBuilder = new StringBuilder();
        foreach (var field in classFields)
        {
            stringBuilder.AppendLine($"{field.Name} must be private!");
        }
        foreach (var method in classNonPublicMethods.Where(m=>m.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be public");
        }
        foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be private");
        }
        return stringBuilder.ToString().Trim();
    }
    
}
