using System;
using System.Collections.Generic;
using System.IO;
// Описываем делегат. В делегате описывается сигнатура методов, на
// которые он сможет ссылаться в дальнейшем (хранить в себе)
public delegate double Fun(double x);
public delegate double Fun2(double x, double a);

class Program
{
    //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
    public static void Table(Fun F, double x, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }

    public static void Table(Fun2 F, double x, double a, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        Console.WriteLine($"a = {a}");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }

    // Создаем методы для передачи их в качестве параметра в Table
    public static double MyFunc(double x)
    {
        return x * x * x;
    }

    public static double MyFunc2(double x, double a)
    {
        return a * x * x;
    }

    public static double MyFunc3(double x, double a)
    {
        return a * Math.Sin(x);
    }

    public static double MyFunc4(double x, double a)
    {
        return a * Math.Cos(x);
    }

    public static double MyFunc5(double x, double a)
    {
        return a - Math.Sqrt(x);
    }

    public static void SaveFunc(Fun2 function, string fileName, double a, double b, double h)
    {
        FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        double x = a;
        while (x <= b)
        {
            bw.Write(MyFunc(x));
            x += h;// x=x+h;
        }
        bw.Close();
        fs.Close();
    }

    //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
    //Пусть она возвращает минимум через параметр (с использованием модификатора out). 
    public static double[] Load(string fileName, out double min)
    {
        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        BinaryReader bw = new BinaryReader(fs);
        min = double.MaxValue;
        double d;
        List<double> outArr = new List<double>();
        for (int i = 0; i < fs.Length / sizeof(double); i++)
        {
            // Считываем значение и переходим к следующему
            d = bw.ReadDouble();
            outArr.Add(d);
            if (d < min) min = d;
        }
        bw.Close();
        fs.Close();
        return outArr.ToArray();
    }


    static void Main()
    {
        Console.WriteLine("Таблица функции MyFunc:");       // Создаем новый делегат и передаем ссылку на него в метод Table
        Table(MyFunc, -2, 2);                               // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом

        Console.WriteLine("Таблица функции a * x^2:");
        Table(MyFunc2, -2, 2, 3);

        Console.WriteLine("Таблица функции a * Sin(x):");
        Table(MyFunc3, -2, 2, 3);
        Console.ReadKey();

        //2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
        //Использовать массив(или список) делегатов, в котором хранятся различные функции.

        List<Fun2> funs = new List<Fun2>();
        funs.Add(MyFunc2);
        funs.Add(MyFunc3);
        funs.Add(MyFunc4);
        funs.Add(MyFunc5);
        int numFunc;

        do
        {
            Console.WriteLine("Введите номер функции:\n" +
                "  1. MyFunc2  - Возвращает значение а * х^2.\n" +
                "  2. MyFunc3  - Возвращает произведение а на синус угла х.\n" +
                "  3. MyFunc4  - Возвращает произведение а на косинус угла х.\n" +
                "  4. MyFunc5  - Возвращает разность числа а и синуса угла х.\n");
            if (int.TryParse(Console.ReadLine(), out numFunc))
            {
                if (numFunc >= 1 && numFunc <= 4)
                {
                    --numFunc;
                    break;
                }
            }

            Console.WriteLine("Необходимо ввести значение от 1 до 4");
            Console.ReadKey();
            Console.Clear();
        } while (true);

        Console.WriteLine("Введите начало интервала:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите конец интервала:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите шаг приращения:");
        double h = double.Parse(Console.ReadLine());

        string fileName = "data_func.txt";
        SaveFunc(funs[numFunc], fileName, a, b, h);
        double[] mass = Load(fileName, out double min);

        for(int i = 0; i < mass.Length; ++i)
            Console.WriteLine($"Элемент массива {i} равен - {mass[i]:0.000}");

        Console.WriteLine($"Минимальное значение массива - {min:0.000}");
        Console.ReadKey();


        void Example() // из методички
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.            
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x) { return x * x; }, 0, 3);
        }
    }
}
