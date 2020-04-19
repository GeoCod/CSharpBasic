using System;
// Описываем делегат. В делегате описывается сигнатура методов, на
// которые он сможет ссылаться в дальнейшем (хранить в себе)
public delegate double Fun(double x);
public delegate double Fun2(double x, double a);

class Program
{
    //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    //2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //Использовать массив(или список) делегатов, в котором хранятся различные функции.
    //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
    //Пусть она возвращает минимум через параметр (с использованием модификатора out). 



    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
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

    static void Main()
    {
        Console.WriteLine("Таблица функции MyFunc:");       // Создаем новый делегат и передаем ссылку на него в метод Table
        Table(MyFunc, -2, 2);                               // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом

        Console.WriteLine("Таблица функции a * x^2:");
        Table(MyFunc2, -2, 2, 3);

        Console.WriteLine("Таблица функции a * Sin(x):");
        Table(MyFunc3, -2, 2, 3);
        Console.ReadKey();


        void Example()
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
