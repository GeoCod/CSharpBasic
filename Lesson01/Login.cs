using System.Text.RegularExpressions;

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

    /* Урок 5. Задание 1
    1.	Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    а) без использования регулярных выражений;
    б) **с использованием регулярных выражений.
    */
    /// <summary>
    /// Проверка корректности пароля без регулярынх выражений
    /// </summary>
    /// <param name="login">Проверяемый логин</param>
    public bool PasswordCheck(string login)
    {
        bool check = false;
        if (login == null) return check;

        char[] sym = login.ToCharArray();
        foreach (char c in sym)
        {
            check = (char.IsLetter(c) || char.IsNumber(c)) ? true : false;
            if (!check) break;
        }
        return check;
    }

    /// <summary>
    /// Проверка корректности пароля c регулярными выражениями
    /// </summary>
    /// <param name="login">Проверяемый логин</param>
    public bool PasswordCheckRegex(string login)
    {
        bool check;
        Regex regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
        return check = regex.Match(login).Success;

        //string pattern = "^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$";    //второй вариант
        //check = Regex.Match(login, pattern).Success;
        //return check;
    }

}

