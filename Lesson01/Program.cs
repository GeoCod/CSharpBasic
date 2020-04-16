using System;
using System.IO;
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
        Console.WriteLine("Задание 1.а.\nПрвоерка логина без рекурсии");
        Console.WriteLine("Введите логин:");
        Login login = new Login();
        if (login.PasswordCheck(Console.ReadLine()))
            Print("Корректный");
        else
            Print("Ошибка");
        Pause();

        //----------------------------------------------
        Console.WriteLine("\nЗадание 1.б.\nПрвоерка логина с рекурсией");
        Console.WriteLine("Введите логин:");
        if (login.PasswordCheckRegex(Console.ReadLine()))
            Print("Корректный");
        else
            Print("Ошибка");
        Pause();
        //-----------------------------------------------

        Print("\nЗадание 2.а.\nВыбор слов соответствующей длины");
        Print("Введите количество символов:");
        int limit = int.Parse(Console.ReadLine());

        Print("Введите предложение:");
        Print("Подходящие слова: " + Message.LetterLimit(Console.ReadLine(), limit));
        Pause();
        //-----------------------------------------------

        Print("\nЗадание 2.б.\nУдаление слов оканчивающиеся на указанный символ");
        Print("Введите символ:");
        char sym = char.Parse(Console.ReadLine());

        Print("Введите слова:");
        Print(Message.DeleteWord(Console.ReadLine(), sym));
        Pause();
        //-----------------------------------------------

        Print("\nЗадание 2.в.\nПоиск самого длинного слова.\nВведите слова:");
        Print("Это слово - " + Message.LongWord(Console.ReadLine()));
        Pause();
        //-----------------------------------------------

        Print("Строка из длинных слов\nВведите слова через пробел:");
        Print("Новая строка:\n" + Message.stringFromLongWord(Console.ReadLine()));
        Pause();
        //-----------------------------------------------

        Print("\nЗадание 2.г.\nПодсчет частоты вхождения слов.");
        string[] words = { "1", "2", "3", "4" };
        string text = "1 1 1 2 2 2 2 2 3 3";
        Print("Новая строка:\n" + Message.WordFrequency(words, text));
        Pause();
        //-----------------------------------------------

        Print("\nЗадание 2.д.\nПроверка текста на перестановку.\nВведите первое сообщение");
        string text1 = Console.ReadLine();
        Print("Введите второе сообщение:");
        string text2 = Console.ReadLine();
        string msg = Message.IsReverse(text1, text2) ? "это перестановка" : "это разные строки";
        Print(msg);
        Pause();


        void Test()
        {
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
        }
    }
}
