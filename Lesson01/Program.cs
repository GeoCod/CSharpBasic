using System;
using System.IO;
using System.Text;
using static View;

public class Program
{
    struct Element
    {
        public string FIO;
        public int N;
    }

    private static void Main()
	//Васильченко Артем
	{

        Console.WriteLine("Задание 1.а");
        Console.WriteLine("Введите логин:");
        Login login = new Login();
        if (login.PasswordCheck(Console.ReadLine()))
            Print("Корректный");
        else
            Print("Ошибка\n");
        Pause();

        Console.WriteLine("Задание 1.б");
        Console.WriteLine("Введите логин:");
        if (login.PasswordCheckRegex(Console.ReadLine()))
            Print("Корректный");
        else
            Print("Ошибка");
        Pause();
        

        return;
        StreamReader sr = new StreamReader("data.txt");
        int N = int.Parse(sr.ReadLine());
        Element[] a = new Element[N];
        for (int i = 0; i < N; i++)
        {
            string[] s = sr.ReadLine().Split(' ');
            a[i].FIO = s[0] + s[1];
            a[i].N = int.Parse(s[2]);
        }
        sr.Close();
        int[] massiv = new int[100];
        for (int i = 0; i < N; i++) massiv[a[i].N]++;
        int min = 100;
        for (int i = 0; i < 100; i++)
            if (massiv[i] != 0 && massiv[i] < min) min = massiv[i];
        for (int i = 0; i < 100; i++)
            if (massiv[i] == min) Console.WriteLine(i);
        Console.ReadKey();

        Pause();


        /*

            string poems = "белеет парус одинокий в тумане моря голубом";
                char[] div = { ' ' }; // создаем массив разделителей
                                      // разбиваем строку на части,
                string[] parts = poems.Split(div);
                Console.WriteLine("Результат разбиения строки на части: ");
                for (int i = 0; i < parts.Length; i++)
                    Console.WriteLine(parts[i]);
                // собираем эти части в одну строку, в качестве разделителя используем символ |
                string str = String.Join("|", parts);
                Console.WriteLine("Результат сборки: ");
                Console.WriteLine(str);
                Pause();
        */


    }
}
