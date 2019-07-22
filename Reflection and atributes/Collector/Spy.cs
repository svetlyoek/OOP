using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string CollectGettersAndSetters(string className)
    {
        Type classType = Type.GetType(className);
        MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        StringBuilder result = new StringBuilder();

        foreach (MethodInfo getterMethods in methods.Where(m => m.Name.StartsWith("get")))
        {
            result.AppendLine($"{getterMethods.Name} will return {getterMethods.ReturnType}");
        }

        foreach (MethodInfo setterMethods in methods.Where(m => m.Name.StartsWith("set")))
        {
            result.AppendLine($"{setterMethods.Name} will set field of {setterMethods.GetParameters().First().ParameterType}");
        }

        return result.ToString().TrimEnd();

    }
}
