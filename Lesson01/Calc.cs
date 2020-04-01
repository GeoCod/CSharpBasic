using System;
using System.Collections.Generic;
using static View;

class Calc
{
    #region Урок 1. Задание 3. Расстояние
    /* 3. Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
    по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;*/
    static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static void RequestCoordinate(out double x1, out double y1, out double x2, out double y2)
    {
        Console.WriteLine("Введите координату Х первой точки:");
        x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату Y первой точки:");
        y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату Х второй точки:");
        x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату Y второй точки:");
        y2 = double.Parse(Console.ReadLine());
    }

    #endregion

    #region Урок 1. Задание 4. Обмен переменных
    /* 4. Написать программу обмена значениями двух переменных.
    а) с использованием третьей переменной;
    б) *без использования третьей переменной */
    void ExchangeVariable()
    {
        int first = 10;     // Присваиваем начальное значение
        int second = 20;    // Присваиваем начальное значение
        int temp = first;   // в temp запоминаем первую переменную
        first = second;     // в первую переписываем значение второй
        second = temp;      // во вторую записываем сохраненное из temp
    }

    void ExchangeVariable2()
    {
        int a = 15;
        int b = 34;
        a = a + b;
        b = a - b;
        a = a - b;
    }

    #endregion

    #region Урок 2. Задание 1
    //Написать метод, возвращающий минимальное из трех чисел.
    /// <summary>
    /// Определяет максимальное из трех чисел
    /// </summary>
    public void MaxNumber()
    {
        Print("Введите первое число");
        int firstNumber = GetInt();

        Print("Введите второе число");
        int secondNumber = GetInt();

        Print("Введите третье число");
        int thirdNumber = GetInt();

        Print("----------------------");

        int maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
        maxNumber = maxNumber > thirdNumber ? maxNumber : thirdNumber;
        Print($"Максимальное число: {maxNumber}");
    }
    #endregion

    #region Урок 2. Задание 2
    //Написать метод подсчета количества цифр числа.
    /// <summary>
    /// Подсчет количества цифр введенного числа
    /// </summary>
    public void countNumeric()
    {
        Print("Введите целое число:");
        int count = GetInt().ToString().Length;
        Print($"Число состоить из {count} цифр");

        /* первая задумка. Но понял, что повторяется код GetInt
            bool isNum = int.TryParse(text, out int Num);
            do
            {
                int count = text.Length;
                Print($"Число состоить из {count} цифр");
            } while (isNum);
        */
    }
    #endregion


    #region Урок 2. Задание 3
    //С клавиатуры вводятся числа, пока не будет введен 0. 
    //Подсчитать сумму всех нечетных положительных чисел.

    /// <summary>
    /// Сумма нечетных положительных чисел
    /// </summary>
    public void sumUneven()
    {
        List<int> numList = new List<int>();
        int num;
        do
        {
            Print("Введите целое число:");
            num = GetInt();
            numList.Add(num);
        } while (num != 0);

        int sum = 0;
        for (int i = 0; i < numList.Count; i++)
        {
            sum = isUneven(numList[i]) && numList[i] > 0 ? sum += numList[i] : sum;
        }
        Print($"Сумма положительных нечетных чисел: {sum}");
    }

    /// <summary>
    /// Сумма нечетных положительных чисел через рекурсию
    /// </summary>
    public void sumUneven2()
    {
        Print("Введите целое число:");
        int num = GetInt();
        int sum = 0;
        if (num != 0)
        {
            if (isUneven(num) && num > 0)
            {
                sum += num;
            }
            sumUneven2();
        }
        Print($"Сумма положительных нечетных чисел: {sum}");
    }

    #endregion

    /// <summary>
    /// Сумма чисел через рекурсию
    /// </summary>
    public int recursion(int a, int b)
    {
        // основное условие задачи
        if (a > b)
        {
            // Базовый случай
            if (a == b)
            {
                return a;
            }
            // Шаг рекурсии / рекурсивное условие
            return a + recursion(a - 1, b);
        }
        else
        {
            // Базовый случай
            if (a == b)
            {
                return a;
            }
            // Шаг рекурсии / рекурсивное условие
            return a + recursion(a + 1, b);
        }
    }
}
