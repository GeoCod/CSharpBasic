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
    public string ToString()
    {
        return re + "+" + im + "i";
    }
}



    class ComplexClass
{
    // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
    public double im;
    public double re;

    public ComplexClass Plus(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = x2.im + this.im;
        x3.re = x2.re + this.re;
        return x3;
    }

    public string ToString()
    {
        return re + "+" + im + "i";
    }
}