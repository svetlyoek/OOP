using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
public class Spy
{
    public string RevealPrivateMethods(string className)
    {
        Type classType = Type.GetType(className);
        MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        StringBuilder result = new StringBuilder();
        result.AppendLine($"All Private Methods of Class: { className}");
        result.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in privateMethods)
        {
            result.AppendLine(method.Name);
        }

        return result.ToString().TrimEnd();
    }
}
