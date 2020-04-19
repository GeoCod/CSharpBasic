using System;
using System.IO;


class MyArray
{
    #region Fields

    int[] _mass;
    #endregion


    #region ClassLifeCycles
    public MyArray() { }

    /// <summary>
    /// Создание массива и заполнение значениями от начального с заданным шагом
    /// </summary>
    /// <param name="size">Количество элементов</param>
    /// <param name="start">Начальное значение</param>
    /// <param name="step">Шаг приращения значений</param>
    public MyArray(int size, int start, int step, char sym) : this(size)
    {
        //_mass = new int[size]; // вместо дублирования вызываем отдельный конструктор
        for (int i = 0; i < size; i++)
        {
            _mass[i] = start;
            start += step;
        }
    }

    /// <summary>
    ///  Создание массива и заполнение его случайными числами от min до max
    /// </summary>
    /// <param name="size">Количество элементов</param>
    /// <param name="min">Минимальное значение</param>
    /// <param name="max">Максимальное значение</param>
    public MyArray(int size, int min, int max) : this(size)
    {
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
            _mass[i] = rnd.Next(min, max);
    }

    public MyArray(int size)
    {
        _mass = new int[size];
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
            _mass = new int[N];
            //  Считываем массив
            for (int i = 0; i < N; i++)
            {
                _mass[i] = int.Parse(sr.ReadLine());
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
            return _mass.Length;
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
            foreach (int el in _mass)
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
            int max = _mass[0];
            for (int i = 1; i < _mass.Length; i++)
                if (_mass[i] > max) max = _mass[i];
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
            int min = _mass[0];
            for (int i = 1; i < _mass.Length; i++)
                if (_mass[i] < min) min = _mass[i];
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
            for (int i = 0; i < _mass.Length; i++)
                if (_mass[i] > 0) count++;
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
        foreach (int v in _mass)
            s = s + v + " ";
        return s;
    }

    /// <summary>
    /// Сортировка методом пузырька
    /// </summary>
    public void BubbleSort()
    {
        for (int i = 0; i < _mass.Length; i++)
            for (int j = 0; j < _mass.Length - 1; j++)
                if (_mass[j] > _mass[j + 1])//Сравниваем соседние элементы
                {
                    //  Обмениваем элементы местами
                    int t = _mass[j];
                    _mass[j] = _mass[j + 1];
                    _mass[j + 1] = t;
                }
    }


    public void Add(int value)
    {
        if (_mass == null)
        {
            _mass = new int[0];
        }
        Array.Resize(ref _mass, _mass.Length + 1);
        _mass[_mass.Length - 1] = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Print(char s = ' ')
    {
        foreach (var el in _mass)
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
        if (_mass == null) return 0;
        int count = 0;

        for (int i = 0; i < _mass.Length - 1; i++)
        {
            if ((isDivisionThree(_mass[i]) && !isDivisionThree(_mass[i + 1])) || (!isDivisionThree(_mass[i]) && isDivisionThree(_mass[i + 1])))
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
        int[] arr = new int[_mass.Length];
        for (int i = 0; i < _mass.Length; i++)
            arr[i] = -_mass[i];
        return arr;
    }

    public void Multi(int num)
    {
        for (int i = 0; i < _mass.Length; i++)
            _mass[i] = _mass[i] * num;
    }
    #endregion



}

