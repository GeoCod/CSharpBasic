using System;
using static System.Console;

public static class View
{
    public static void Pause()
    {
        ReadKey();
    }

    public static void Print(object value)
    {
        WriteLine(value);
    }

    public static string GetString()
    {
        return ReadLine();
    }

    public static int GetInt()
    {
        //return Int32.TryParse(GetString());
        return Int32.Parse(GetString());
    }

    public static double GetDouble()
    {
        return Double.Parse(GetString().Replace('.', ','));
    }
}