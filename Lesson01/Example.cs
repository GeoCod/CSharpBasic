using System;
using static View;

public class Example
{
    public void MaxNumber()
    {
        Print("Введите первое число");
        int firstNumber = GetInt();

        Print("Введите второе число");
        int secondNumber = GetInt();

        Print("Введите третье число");
        int thirdNumber = GetInt();

        Print("----------------------");

        int maxNumber = 0;

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                maxNumber = firstNumber;
            }
            else
            {
                maxNumber = thirdNumber;
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                maxNumber = secondNumber;
            }
            else
            {
                maxNumber = thirdNumber;
            }
        }

        //int maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
        Print(maxNumber);
    }

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
}