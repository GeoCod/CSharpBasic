﻿using System;
using static View;

public class Program
{
    private static void Main()
    //Васильченко Артем
    {
        #region Урок 3
        
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
        }


        void ComplexClass()
        {
            ComplexClass complex1 = new ComplexClass();
            complex1.re = 1;
            complex1.im = 1;

            ComplexClass complex2 = new ComplexClass();
            complex2.re = 2;
            complex2.im = 2;

            ComplexClass result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
        }

        ComplexStruct();
        ComplexClass();
        Pause();
        return;

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
