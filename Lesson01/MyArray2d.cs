using System;

class MyArray2d
{
    #region Fields

    int[,] Mass;
    #endregion


    #region ClassLifeCycles
    /// <summary>
    ///  Создание двумерного массива и заполнение его случайными числами от min до max
    /// </summary>
    /// <param name="n">Количество строе</param>
    /// <param name="m">Количество столбцов</param>
    /// <param name="min">Минимальное значение</param>
    /// <param name="max">Максимальное значение</param>
    public MyArray2d(int n, int m, int min, int max)
    {
        Mass = new int[n, m];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                Mass[i, j] = rnd.Next(min, max);
    }

    #endregion


    #region Properties

    public int Max
    {
        get
        {
            int max = Mass[0, 0];
            for (int row = 0; row < Mass.GetLength(0); row++)
                for (int col = 0; col < Mass.GetLength(1); col++)
                    if (Mass[row, col] >= max) max = Mass[row, col];
            return max;
        }
    }

    public int Min
    {
        get
        {
            int min = Mass[0, 0];
            for (int row = 0; row < Mass.GetLength(0); row++)
                for (int col = 0; col < Mass.GetLength(1); col++)
                    if (Mass[row, col] <= min) min = Mass[row, col];
            return min;
        }
    }
    #endregion


    #region Method

    public int Sum()
    {
        int sum = 0;
        foreach (int el in Mass)
        {
            sum += el;
        }
        return sum;
    }

    public int Sum(int num)
    {
        int sum = 0;
        foreach (int el in Mass)
        {
            if (el > num)
                sum += el;
        }
        return sum;
    }

    public void CoordMaxNum(out int _row, out int _col)
    {
        _row = 0; _col = 0;
        int max = Mass[0, 0];
        for (int row = 0; row < Mass.GetLength(0); row++)
            for (int col = 0; col < Mass.GetLength(1); col++)
                if (Mass[row, col] >= max)
                {
                    _row = row;
                    _col = col;
                }
    }


    /// <summary>
    /// Элементы массива в строку
    /// </summary>
    public override string ToString()
    {
        string s = "";
        foreach (int v in Mass)
            s = s + v + " ";
        return s;
    }
    /*/// <summary>
    /// Номер максимального элемента
    /// </summary>
        public Tuple<int, int> CoordinatesOf<T>(this T[,] matrix, T value)
        {
            int w = matrix.GetLength(0); // width
            int h = matrix.GetLength(1); // height

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    if (matrix[x, y].Equals(value))
                        return Tuple.Create(x, y);
                }
            }
            return Tuple.Create(-1, -1);
        }*/
    #endregion


}