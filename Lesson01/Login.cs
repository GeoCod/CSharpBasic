using System;
using static View;


public class Login
{
    /* Урок 2. Задание 4.
     Реализовать метод проверки логина и пароля.
     На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, 
     и ложь, если не прошел(Логин: root, Password: GeekBrains). 
     Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
     программа пропускает его дальше или не пропускает.
     С помощью цикла do while ограничить ввод пароля тремя попытками.
     */
     public bool Authorization(string login, string pass)
    {
        string validLogin = "root";
        string validPassword = "GeekBrains";
        bool verifi = login == validLogin && pass == validPassword ? true : false;
        return verifi;
    }
}

