using System;

namespace Lesson01
{
    class Program
    {
        //Васильченко Артем
        static void Main(string[] args)
        {
            //1. Анкета и ИМТ
            Questionnaire();

            //3. Расстояние между точками
            RequestCoordinate(out double x1, out double y1, out double x2, out double y2);
            double dist = Distance(x1, y1, x2, y2);
            Console.WriteLine($"Точки находятся на расстоянии: {dist:f2}");
            Console.ReadLine();

            //5. Вывод в центре консоли
            PrintCenterScreen();

        }

        #region Задания 1 и 2. Анкета и ИМТ
        /* 1. Анкета
        Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
        В результате вся информация выводится в одну строчку.
        а) используя склеивание;
        б) используя форматированный вывод;
        в) *используя вывод со знаком $. */
        static void Questionnaire()
        {
            Console.WriteLine("Вас приветствует программа \"Анкета\"");
            Console.WriteLine("Введите Ваше имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Сколько Вам полных лет:");
            int age = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Укажите Ваш рост в см:");
            int height = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Укажите Ваш вес в кг:");
            int weight = Int16.Parse(Console.ReadLine());

            //склеивание строк
            Console.WriteLine(lastName + " " + firstName + ", " + age + " лет, рост - " + height + ", вес - " + weight + " кг.");
            Console.WriteLine();

            //форматированный вывод
            Console.WriteLine("{0} {1}, {2} лет, рост - {3}, вес - {4} кг.", lastName, firstName, age, height, weight);

            //вывод со знаком $
            Console.WriteLine();
            Console.WriteLine($"{lastName} {firstName}, {age} лет, рост - {height}, вес - {weight} кг.");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();

            /* 2. ИМТ
            Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); 
            где m — масса тела в килограммах, h — рост в метрах */
            double heightMetres = (double)height / 100;     //переводим рост см в метры
            double BMI = weight / (heightMetres * heightMetres);
            Console.WriteLine($"Ваш индекс массы тела составляет: {BMI:f2}");
            Console.ReadLine();
        }

        #endregion


        #region Задание 3. Расстояние
        /* 3. Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
        Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;*/
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2));
        }

        static void RequestCoordinate(out double x1, out double y1, out double x2, out double y2)
        {
            Console.WriteLine("Введите координату Х первой точки:");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой точки:");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Х второй точки:");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки:");
            y2 = double.Parse(Console.ReadLine());
        }

        #endregion


        #region Задание 4. Обмен переменных
        /* 4. Написать программу обмена значениями двух переменных.
        а) с использованием третьей переменной;
        б) *без использования третьей переменной */
        void ExchangeVariable()
        {
            int first = 10;     // Присваиваем начальное значение
            int second = 20;    // Присваиваем начальное значение
            int temp = first;   // в temp запоминаем первую переменную
            first = second;     // в первую переписываем значение второй
            second = temp;      // во вторую записываем сохраненное из temp
        }

        void ExchangeVariable2()
        {
            int a = 15;
            int b = 34;
            a = a + b;
            b = a - b;
            a = a - b;
        }

        #endregion


        #region Задание 5. Вывод ФИО +Перегрузка методов для своих функций
        /* 5. Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        б) Сделать задание, только вывод организуйте в центре экрана
        в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y) */
        static void PrintCenterScreen()
        {
            Console.WriteLine("Введите Ваше имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Укажите город вашего проживания:");
            string city = Console.ReadLine();

            string text = $"{firstName} {lastName}, {city}";

            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(text);
            Console.ReadLine();
        }

        static void Print(int x, int y)
        {
            Console.WriteLine("Введите Ваше имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Укажите город вашего проживания:");
            string city = Console.ReadLine();

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine($"{firstName} {lastName}, {city}");
            Console.ReadLine();
        }

        static void Print(string firstName, string lastName, string city, int x, int y)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine($"{firstName} {lastName}, {city}");
            Console.ReadLine();
        }
        #endregion


        #region Задание 6. Создание класса
        /* 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause). Достаточно решить 3 задачи. 
        Записывайте в начало программы условие и свою фамилию. Все программы создавайте в одном решении. 
        Задания со звездочками выполняйте в том случае, если вы решили задачи без звездочек */
        class Learn
        {
            #region Fields
            // TODO вынести поля из методов
            // пока непонятно что может пригодиться

            #endregion


            #region Properties
            // TODO добавить свойства
            // пока непонятно что может пригодиться

            #endregion


            #region Methods

            /// <summary>
            /// Ожидание ввода пользователя
            /// </summary>
            static void Pause()
            {
                Console.ReadKey();
            }

            /// <summary>
            /// Вывод сообщения и ожидание воода пользователя
            /// </summary>
            /// <param name="msg">Текст сообщения</param>
            static void Pause(string msg)
            {
                Console.WriteLine(msg);
                Console.ReadKey();
            }

            /// <summary>
            /// Запрашивает Фамилию, Имя, Город и выводит в указанном месте консоли
            /// </summary>
            /// <param name="x">Отступ слева</param>
            /// <param name="y">Отступ сверху</param>
            static void Print(int x, int y)
            {
                Console.WriteLine("Введите Ваше имя:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Введите Вашу фамилию:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Укажите город вашего проживания:");
                string city = Console.ReadLine();

                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"{firstName} {lastName}, {city}");
                Console.ReadLine();
            }

            /// <summary>
            /// Выводит Фамилию, Имя, Город в указанном месте консоли
            /// </summary>
            /// <param name="firstName">Имя</param>
            /// <param name="lastName">Фамилия</param>
            /// <param name="city">Город</param>
            /// <param name="x">Отступ слева</param>
            /// <param name="y">Отступ сверху</param>
            static void Print(string firstName, string lastName, string city, int x, int y)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"{firstName} {lastName}, {city}");
                Console.ReadLine();
            #endregion

            #endregion

            }
        }
    }
}
