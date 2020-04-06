using System;

struct ComplexStruct
{
    public double im;
    public double re;
    //  в C# в структурах могут храниться также действия над данными
    public ComplexStruct Plus(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    //  Пример произведения двух комплексных чисел
    public ComplexStruct Multi(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    // Вычитание комплексных чисел
    public ComplexStruct Minus(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

    public string ToString()
    {
        return re + "+" + im + "i";
    }
}



    class ComplexClass
{
    // Поля приватные.
    private double im;
    // По умолчанию элементы приватные, поэтому private можно не писать.
    double re;

    // Конструктор без параметров.
    public ComplexClass()
    {
        im = 0;
        re = 0;
    }

    // Конструктор, в котором задаем поля.    
    // Специально создадим параметр re, совпадающий с именем поля в классе.
    public ComplexClass(double _im, double re)
    {
        // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
        im = _im;
        // Чтобы показать, что к полю нашего класса присваивается параметр,
        // используется ключевое слово this
        // Поле параметр
        this.re = re;
    }
    public ComplexClass Plus(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }

    public ComplexClass Minus(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = x2.im - im;
        x3.re = x2.re - re;
        return x3;
    }

    public ComplexClass Multi(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = re * x2.im + im * x2.re;
        x3.re = re * x2.re - im * x2.im;
        return x3;
    }
    // Свойства - это механизм доступа к данным класса.
    public double Im
    {
        get { return im; }
        set
        {
            // Для примера ограничимся только положительными числами.
            if (value >= 0) im = value;
        }
    }
    // Специальный метод, который возвращает строковое представление данных.
    public string ToString()
    {
        return re + "+" + im + "i";
    }

}