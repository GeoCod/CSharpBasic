using System;
using System.Globalization;
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
        bool verification;
        int number;
        do
        {
            verification = Int32.TryParse(GetString(), out number);
            if (!verification)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Print("Введите целое число:");
                Console.ForegroundColor = ConsoleColor.White;
            }
        } while (!verification);
        return number;
    }

    /// <summary>
    /// Проверяет является ли число четным
    /// </summary>
    public static bool isEven(int num)
    {
        return num % 2 == 0;
    }

    /// <summary>
    /// Проверяет является ли число нечетным
    /// </summary>
    public static bool isUneven(int num)
    {
        return num % 2 != 0;
    }

    public static double GetDouble()
    {
        double d = double.Parse(GetString().Replace(",", "."), CultureInfo.InvariantCulture);
        return d;
        //return Double.Parse(GetString().Replace('.', ','));
    }
}