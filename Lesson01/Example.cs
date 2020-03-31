using System;
using System.Collections.Generic;
using static View;

public class Example
{
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

    /// <summary>
    /// Подсчет количества цифр введенного числа
    /// </summary>
    public void countNumeric ()
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

    /// <summary>
    /// Сумма нечетных положительных чисел
    /// </summary>
    public void sumUneven ()
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
        for(int i = 0; i < numList.Count; i++)
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
        if(num != 0)
        {
            if(isUneven(num) && num > 0)
            {
                sum += num;
            }
            sumUneven2();
        }
        Print($"Сумма положительных нечетных чисел: {sum}");
    }


    #region Примеры из урока
    public void ExampleIf()
    {
        // && и
        // || или
        if (false)
        {
            Print("No");
        }
        else if (true || false)
        {
            Print("Yes");
        }
        else
        {
            Print("MB");
        }
    }

    public void GetJob()
    {
        Print("Сколько тебе лет?");

        int age = GetInt();

        if (age >= 18)
        {
            Print("Го работать");
        }
        else
        {
            GetJob();
        }
    }

    public void GetDay()
    {
        Print("Введите день недели");

        int day = GetInt();

        switch (day)
        {
            case 1:
                {
                    Print("Понедельник");
                    break;
                }
            case 2:
                {
                    Print("Вторник");
                    break;
                }
            case 3:
                {
                    Print("Среда");
                    break;
                }
            case 4:
                {
                    Print("Четверг");
                    break;
                }
            case 5:
                {
                    Print("Пятница");
                    break;
                }
            case 6:
            case 7:
                {
                    Print("Суббота или воскресенье");
                    break;
                }
            default:
                {
                    Print("Нет такого");
                    break;
                }
        }
    }

    public void LevelSelect()
    {
        Print("Выберете уровень сложности");

        int level = GetInt();

        switch (level)
        {
            case (int)LevelSelection.Easy:
                Print("10 zombi");
                break;
            case (int)LevelSelection.Normal:
                Print("20 zombi");
                break;
            case (int)LevelSelection.Hard:
                Print("50 zombi");
                break;
            default:
                Print("0 zombi");
                break;
        }
    }

    public void ExampleFor()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                //continue;
                //break;
                //return;
            }
            Print($"{i}) Roman");
        }
    }

    public void ExampleWhile()
    {
        int i = 1;
        while (i >= 10)
        {
            Print($"{i}) Roman");
            i++;
        }

        i = 1;

        do
        {
            Print($"{i}) Ivan");
            i++;
        } while (i >= 10);
    }

    public void ExampleTryInt()
    {
        int number;
        bool isNumber;
        do
        {
            Print("Введите число");
            isNumber = Int32.TryParse(GetString(), out number);
        } while (!isNumber);
    }
    #endregion
}