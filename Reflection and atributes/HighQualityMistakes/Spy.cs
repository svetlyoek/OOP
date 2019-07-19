using System;
using System.Linq;
using System.Reflection;
using System.Text;
public class Spy
{
    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] fields = classType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance);
        MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
        MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder result = new StringBuilder();

        foreach (FieldInfo field in fields)
        {
            result.AppendLine($"{field.Name} must be private!");
        }

        foreach (MethodInfo method in nonPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            result.AppendLine($"{method.Name} have to be public!");
        }

        foreach (MethodInfo method in publicMethods.Where(m => m.Name.StartsWith("set")))
        {
            result.AppendLine($"{method.Name} have to be private!");
        }

        return result.ToString().TrimEnd();
    }
}

