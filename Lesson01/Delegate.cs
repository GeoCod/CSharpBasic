﻿using System;

public class Delegate
{
    //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    //2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //Использовать массив(или список) делегатов, в котором хранятся различные функции.
    //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
    //Пусть она возвращает минимум через параметр (с использованием модификатора out). 

    public delegate double CallFunction(double num);    //объявили делегат
    public CallFunction Function;   //создали делегат
    
    public double GetFunction()
    {
        Function.Invoke()
    }


    public double F1(double x)
    {
        return x * x - 50 * x + 10;
    }

    public double F2(double x, double a)
    {
        return a * x * x;
    }

    public double F3(double x, double a)
    {
        return a * Math.Sin(x);
    }

}