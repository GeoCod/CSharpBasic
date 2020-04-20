using System;

namespace Less_07
{
    public class Numeric
    {
        // в) *Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
        // Вся логика игры должна быть реализована в классе с удвоителем.
        private int num;
        Random rnd = new Random();
        public int RandomNum
        {
            get { return num = rnd.Next(100); }
        }

    }
}
