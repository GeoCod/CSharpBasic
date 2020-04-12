using System;
using System.IO;


class MyArray
{
    #region Fields

    int[] Mass;
    #endregion


    #region ClassLifeCycles
    public MyArray() { }

    /// <summary>
    /// Создание массива и заполнение значениями от начального с заданным шагом
    /// </summary>
    /// <param name="size">Количество элементов</param>
    /// <param name="start">Начальное значение</param>
    /// <param name="step">Шаг приращения значений</param>
    public MyArray(int size, int start, int step, char sym)
    {
        Mass = new int[size];
        for (int i = 0; i < size; i++)
        {
            Mass[i] = start;
            start += step;
        }
    }

    /// <summary>
    ///  Создание массива и заполнение его случайными числами от min до max
    /// </summary>
    /// <param name="n">Количество элементов</param>
    /// <param name="min">Минимальное значение</param>
    /// <param name="max">Максимальное значение</param>
    public MyArray(int n, int min, int max)
    {
        Mass = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
            Mass[i] = rnd.Next(min, max);
    }

    /// <summary>
    /// Создание массива и заполнение его значениями из файла
    /// </summary>
    /// <param name="filename">Путь к файлу</param>
    public MyArray(string fileName)
    {
        if (String.IsNullOrEmpty(fileName) || !File.Exists(fileName)) return;

        StreamReader sr = new StreamReader(fileName);
        try
        {
            int N = int.Parse(sr.ReadLine());
            Mass = new int[N];
            //  Считываем массив
            for (int i = 0; i < N; i++)
            {
                Mass[i] = int.Parse(sr.ReadLine());
            }
        }
        finally
        {
            sr.Close();
        }
    }
    #endregion


    #region Properties

    /// <summary>
    /// Длина массива
    /// </summary>
    public int Length
    {
        get
        {
            return Mass.Length;
        }
    }

    /// <summary>
    /// Сумма элементов массива
    /// </summary>
    public double Sum
    {
        get
        {
            double sum = 0;
            foreach (int el in Mass)
                sum += el;
            return sum;
        }
    }

    /// <summary>
    /// Максимальное значение массива
    /// </summary>
    public int Max
    {
        get
        {
            int max = Mass[0];
            for (int i = 1; i < Mass.Length; i++)
                if (Mass[i] > max) max = Mass[i];
            return max;
        }
    }

    /// <summary>
    /// Минимальное значение массива
    /// </summary>
    public int Min
    {
        get
        {
            int min = Mass[0];
            for (int i = 1; i < Mass.Length; i++)
                if (Mass[i] < min) min = Mass[i];
            return min;
        }
    }

    /// <summary>
    /// Количество положительных значений массива
    /// </summary>
    public int CountPositiv
    {
        get
        {
            int count = 0;
            for (int i = 0; i < Mass.Length; i++)
                if (Mass[i] > 0) count++;
            return count;
        }
    }
    #endregion


    #region Methods

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

    /// <summary>
    /// Сортировка методом пузырька
    /// </summary>
    public void BubbleSort()
    {
        for (int i = 0; i < Mass.Length; i++)
            for (int j = 0; j < Mass.Length - 1; j++)
                if (Mass[j] > Mass[j + 1])//Сравниваем соседние элементы
                {
                    //  Обмениваем элементы местами
                    int t = Mass[j];
                    Mass[j] = Mass[j + 1];
                    Mass[j + 1] = t;
                }
    }


    public void Add(int value)
    {
        if (Mass == null)
        {
            Mass = new int[0];
        }
        Array.Resize(ref Mass, Mass.Length + 1);
        Mass[Mass.Length - 1] = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Print(char s = ' ')
    {
        foreach (var el in Mass)
            Print($"{s}{el}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    public void Print(string msg)
    {
        Console.WriteLine(msg);
        Print();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    public void Write(string path)
    {
        if (String.IsNullOrEmpty(path)) return;
        StreamWriter sw = new StreamWriter(path);


        //sw.Flush;
        //sw.Close;
    }

    /// <summary>
    /// Поиск пар элементов одна из которых делится на 3
    /// </summary>
    /// <returns>Количество пар массива, в которых только одно число делится на 3</returns>
    public int CountCoupleDivThree()
    {
        if (Mass == null) return 0;
        int count = 0;

        for (int i = 0; i < Mass.Length - 1; i++)
        {
            if ((isDivisionThree(Mass[i]) && !isDivisionThree(Mass[i + 1])) || (!isDivisionThree(Mass[i]) && isDivisionThree(Mass[i + 1])))
            {
                count++;
            }
        }
        return count;
    }

    private bool isDivisionThree(int num)
    {
        return num % 3 == 0;
    }

    public int[] Inverse()
    {
        int[] arr = new int[Mass.Length];
        for (int i = 0; i < Mass.Length; i++)
            arr[i] = -Mass[i];
        return arr;
    }

    public void Multi(int num)
    {
        for (int i = 0; i < Mass.Length; i++)
            Mass[i] = Mass[i] * num;
    }
    #endregion



}

