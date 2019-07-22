using System;
public class StartUp
{
    private static void Main()
    {
        var spy = new Spy();
        string result = spy.AnalyzeAcessModifiers("Hacker");
        Console.WriteLine(result.ToString());

    }
}

