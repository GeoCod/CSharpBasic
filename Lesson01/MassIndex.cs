using System;
using static View;

public class MassIndex
{
    string firstName;
    string lastName;
    int age;
    double height;
    double weight;

    /* Урок 1. Задание 1. Анкета
    Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
    В результате вся информация выводится в одну строчку.
    а) используя склеивание;
    б) используя форматированный вывод;
    в) *используя вывод со знаком $. */
    public void Questionnaire()
    {
        Console.WriteLine("Вас приветствует программа \"Анкета\"");
        Console.WriteLine("Введите Ваше имя:");
        firstName = Console.ReadLine();

        Console.WriteLine("Введите Вашу фамилию:");
        lastName = Console.ReadLine();

        Console.WriteLine("Сколько Вам полных лет:");
        age = Int16.Parse(Console.ReadLine());

        Console.WriteLine("Укажите Ваш рост, в см:");
        height = GetDouble();

        Console.WriteLine("Укажите Ваш вес, в кг:");
        weight = GetDouble();
        /*
        //склеивание строк
        Console.WriteLine(lastName + " " + firstName + ", " + age + " лет, рост - " + height + ", вес - " + weight + " кг.");
        Console.WriteLine();

        //форматированный вывод
        Console.WriteLine("{0} {1}, {2} лет, рост - {3}, вес - {4} кг.", lastName, firstName, age, height, weight);
        //вывод со знаком $
        Console.WriteLine();
        Console.WriteLine($"{lastName} {firstName}, {age} лет, рост - {height:f2}, вес - {weight:f2} кг.");
        Console.WriteLine("----------------------------------------------------------------");
        Pause();
        */

    }


    /* Урок 1. Задание 2. ИМТ
    Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); 
    где m — масса тела в килограммах, h — рост в метрах */
    public void BMI()
    {
        //weight = GetDouble();
        double heightMetr = height / 100;
        double BMI = weight / (heightMetr * heightMetr);
        Print($"Ваш индекс массы тела составляет: {BMI:f2}");
        RecomendationBMI(BMI);
        RequiredWeight(BMI);
        Pause();
    }

    // Урок 2. Задание 5а
    public void RecomendationBMI(double index)
    {
        string recomendation;
        if (index <= 16)
        // 16 и менее  Выраженный дефицит массы тела
        {
            recomendation = "Вызывайте доктора! Вас срочно нужно откармливать";
        }
        else if (index < 18.5)
        // 16—18,5 Недостаточная(дефицит) масса тела
        {
            recomendation = "Вам бы больше налегать на еду";
        }
        else if (index < 25)
        // 18,5—24,99  Норма
        {
            recomendation = "У вас все в порядке. Продолжайте в томже духе.";
        }
        else if (index < 30)
        // 25—30   Избыточная масса тела(предожирение)
        {
            recomendation = "Вам необходимо больше пеших прогулок";
        }
        else if (index < 35)
        // 30—35   Ожирение
        {
            recomendation = "Вам требуются регулярные тренировки";
        }
        else if (index < 40)
        // 35—40   Ожирение резкое
        {
            recomendation = "Рекомендуем строгую диету и интенсивыне тренировки";
        }
        else
        // 40 и более  Очень резкое ожирение
        {
            recomendation = "Вызывайте доктора! Больше набирать уже нельзя!";
        }
        Print(recomendation);
    }

    // Урок 2. Задание 5б
    public void RequiredWeight(double index)
    {
        double requiredWeight = 0;
        if (index <= 18.5)
        {
            requiredWeight = 18.5 / index * weight - weight;
            Print($"Вам необходимо набрать {requiredWeight:f1} кг");
        }
        else if (index >=25)
        {
            requiredWeight = weight - (25 / index * weight);
            Print($"Вам необходимо сбросить {requiredWeight:f1} кг");
        }
    }

    #region Урок 1. Задание 5. Вывод ФИО +Перегрузка методов для своих функций
    /* 5. Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    б) Сделать задание, только вывод организуйте в центре экрана
    в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y) */
    public void PrintCenterScreen()
    {
        Print("Введите Ваше имя:");
        firstName = GetString();

        Print("Введите Вашу фамилию:");
        lastName = GetString();

        Print("Укажите город вашего проживания:");
        string city = GetString();

        string text = $"{firstName} {lastName}, {city}";

        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2);
        Print(text);
        Console.ReadLine();
    }
    #endregion
}

