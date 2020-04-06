class FractionalNumber
{
/*
3.	*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
*** Добавить упрощение дробей.
*/
    int denominator;
    int numerator;
    int wholeNum;

    public FractionalNumber()
    {
        denominator = 1;
        numerator = 1;
        wholeNum = 0;
    }

    public FractionalNumber(int _denominator, int _numnator)
    {
        denominator = _denominator;
        numerator = _numnator;
        wholeNum = 0;
    }

    public FractionalNumber(int _denominator, int _numnator, int _wholeNum)
    {
        denominator = _denominator;
        numerator = _numnator;
        wholeNum = _wholeNum;
    }

}
