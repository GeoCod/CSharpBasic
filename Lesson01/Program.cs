using System;
using static View;

public class Program
{
    private static void Main()
    //Васильченко Артем
    {
        #region Урок 4

        Print("Заадние 1");
        MyArray Mass = new MyArray(20, -10000, 10000);
        Print(Mass.CountCoupleDivThree());
        Pause();

        //Задание 2


        Print("Заадние 3");
        MyArray Mass2 = new MyArray(10, -355, 15, 'R');     // Как лучше было сделать два похожих конструктора? Есть мин-макс и с шагом
        Print(Mass2.Sum);
        Pause();
        Print("");

        Print("--метод Inverse");
        Mass2.Inverse();
        Print(Mass2.ToString());
        Pause();
        Print("");

        Print("--метод Multi");
        Mass2.Multi(10);
        Print(Mass2.ToString());
        Pause();
        Print("");

        Print("Задание 4");
        MyArray2d Mass2d = new MyArray2d(3, 5, 0, 500);
        int X, Y;
        Print(Mass2d.ToString());
        Mass2d.CoordMaxNum(out X, out Y);
        Print(X); Print(Y);
        Pause();

        #endregion
    }
}
