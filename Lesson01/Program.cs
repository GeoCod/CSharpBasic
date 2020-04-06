using System;
using static View;

public class Program
{
    private static void Main()
    //Васильченко Артем
    {
        #region Урок 3

        ComplexStruct();
        Print("-------------");
        ComplexClass();
        Print("-------------");
        SumUneven();
        Print("-------------");
        Pause();
        return;

        void SumUneven()
        {
            // 2.а)  С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
            // Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse.
            Calc calc2 = new Calc();
            calc2.sumUneven();
        }

        void ComplexStruct()
        {
            ComplexStruct complex1;
            complex1.re = 1;
            complex1.im = 1;

            ComplexStruct complex2;
            complex2.re = 2;
            complex2.im = 2;

            ComplexStruct result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());

            // 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
            ComplexStruct result2 = complex2.Minus(complex1);
            Console.WriteLine(result2.ToString());
        }


        void ComplexClass()
        {
            // 1.б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
            // 1.в) Добавить диалог с использованием switch демонстрирующий работу класса.

            // Описали ссылку на объект.
            ComplexClass complex1;
            // Создали объект и сохранили ссылку на него в complex1.
            complex1 = new ComplexClass(1, 1);
            // Описали объект и создали его.
            ComplexClass complex2 = new ComplexClass(2, 2);
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            //complex2.Im = 3;
            // Создали ссылку на объект.
            ComplexClass result;
            // Так как в методе Plus создается новый объект,
            // в result сохраняем ссылку на вновь созданный объект.

            /*
            result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());

            ComplexClass result2;
            result2 = complex1.Multi(complex2);
            Console.WriteLine(result2.ToString());

            ComplexClass result3;
            result3 = complex1.Minus(complex2);
            Console.WriteLine(result3.ToString());
            */

            Console.WriteLine("Для сложения чисел введите - 1, вычитания - 2, умножения - 3:");
            result = null;
            string switchCase = Console.ReadLine();
            switch (switchCase)
            {
                case "1":
                    {
                        result = complex1.Plus(complex2);
                        break;
                    }
                case "2":
                    {
                        result = complex1.Multi(complex2);
                        break;
                    }
                case "3":
                    {
                        result = complex1.Minus(complex2);
                        break;
                    }
                default:
                    break;
            }
            Console.WriteLine(result.ToString());
        }

        #endregion




        Calc calc = new Calc();

        //1. Написать метод, возвращающий минимальное из трёх чисел.
        calc.MaxNumber();
        Pause();
        Print("---------------------");

        // 2. Написать метод подсчета количества цифр числа
        calc.countNumeric();
        Pause();
        Print("---------------------");

        // 3.С клавиатуры вводятся числа, пока не будет введен 0. 
        // Подсчитать сумму всех нечетных положительных чисел.
        calc.sumUneven();
        //calc.sumUneven2(); //рекурсия. Пока не получилось
        Pause();
        Print("---------------------");


        #region Урок 2. Задание 4
        /* Задание 4.
         Реализовать метод проверки логина и пароля.
         На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, 
         и ложь, если не прошел(Логин: root, Password: GeekBrains). 
         Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
         программа пропускает его дальше или не пропускает.
         С помощью цикла do while ограничить ввод пароля тремя попытками. */

        Login login = new Login();
        Print("Необходимо авторизоваться.");

        int tryCount = 3;
        int tryNumber = 1;
        do
        {
            Print("Введите логин:");
            string loginUser = GetString();
            Print("Введите пароль:");
            string passUser = GetString();
            if (login.Authorization(loginUser, passUser))
            {
                Print("Добро пожаловать!");
                Pause();
                break;
            }
            else
            {
                if (tryNumber == tryCount)
                {
                    Print("Иди вспоминай логин/пароль");
                }
                else
                {
                    Print("Попробуй еще раз");
                }
            }
            tryNumber++;
        } while (tryNumber <= tryCount);
        Print("---------------------");
        Pause();

        #endregion


        // Задание 5
        // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы 
        //    и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        MassIndex mass = new MassIndex();
        mass.Questionnaire();
        mass.BMI();
        Pause();
        Print("---------------------");


        /* 6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            «Хорошим» называется число, которое делится на сумму своих цифр.
            Реализовать подсчёт времени выполнения программы, используя структуру DateTime. */



        //7.a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
        Print("Введите первое число:");
        int numFirst = GetInt();
        Print("Введите второе число:");
        int numSecond = GetInt();
        GetNumber();

        void GetNumber()
        {
            int counter = numSecond - numFirst;
            if (counter != 0)
            {
                Print(numSecond--);
                counter--;
                GetNumber();
            }
        }
        Print("---------------------");
        Pause();


        //7.б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        Print("Введите первое число:");
        int numOne = GetInt();
        Print("Введите второе число:");
        int numTwo = GetInt();
        Print($"Сумма чисел равна: {calc.recursion(numOne, numTwo)}");
        Pause();
    }
}
