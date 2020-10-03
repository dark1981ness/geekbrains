using System;
using static Exercise6.Program;

namespace Less3Ex1
{
    // выполнил - Noskov Konstantin
    //
    //задача:
    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.

    class Program
    {
        struct Complex
        {
            public double im;
            public double re;
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            // вычитание двух комплексных чисел
            public Complex Subtr(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public string ToString()
            {
                if(im < 0)
                {
                    return re.ToString() + im.ToString() + "i";
                }
                else
                {
                    return re + "+" + im + "i";
                }
                
            }
        }

        class ComplexClass
        {
            // Поля приватные.
            private int im;
            // По умолчанию элементы приватные, поэтому private можно не писать.
            int re;

            // Конструктор без параметров.
            public ComplexClass()
            {
                im = 0;
                re = 0;
            }

            // Конструктор, в котором задаем поля.    
            // Специально создадим параметр re, совпадающий с именем поля в классе.
            public ComplexClass(int _im, int re)
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

            public ComplexClass Subtr(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public ComplexClass Multi(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            // Свойства - это механизм доступа к данным класса.
            public int Im
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
                if (im < 0)
                {
                    return re.ToString() + im.ToString() + "i";
                }
                else
                {
                    return re + "+" + im + "i";
                }
            }
        }

        

        static void Main(string[] args)
        {

            #region Complex Struct
            //Console.WriteLine($"/****** fun with struct ******/");
            //Complex complex1;
            //complex1.re = 1;
            //complex1.im = 1;

            //Complex complex2;
            //complex2.re = 2;
            //complex2.im = 2;

            //Complex result = complex1.Plus(complex2);
            //Console.WriteLine(result.ToString());
            //result = complex1.Multi(complex2);
            //Console.WriteLine(result.ToString());
            //result = complex1.Subtr(complex2);
            //Console.WriteLine(result.ToString());

            #endregion

            #region Complex Class

            do
            {
                PrintMsg($"/****** Действия над комплексными числами ******/", ConsoleColor.DarkYellow);
                PrintMsg($"1. Сложение", ConsoleColor.DarkYellow);
                PrintMsg($"2. Вычитание", ConsoleColor.DarkYellow);
                PrintMsg($"3. Умножение", ConsoleColor.DarkYellow);
                PrintMsg($"4. Выход из программы", ConsoleColor.DarkYellow);
                menuValue = GetUserValue();
                switch (menuValue)
                {
                    case 1:
                        OperationComplexNum(1);
                        break;
                    case 2:
                        OperationComplexNum(2);
                        break;
                    case 3:
                        OperationComplexNum(3);
                        break;
                    case 4:
                        Environment.Exit(-1);
                        break;
                }

            } while (menuValue != 4);

            #endregion

        }

        static int menuValue;

        static int GetUserValue()
        {
            int num;
            do
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"Введено неверное значение, попробуйте снова");
                }
            } while (false);
            return num;
        }
        
        private static ComplexClass UserInputNums()
        {
            int im, re;
            PrintMsg($"Введите мнимую часть числа:", ConsoleColor.DarkYellow);
            im = GetUserValue();
            PrintMsg($"Введите вещественную часть числа:", ConsoleColor.DarkYellow);
            re = GetUserValue();
            return _ = new ComplexClass(im, re);
        }

        private static void OperationComplexNum(int menuNum)
        {
            int im;
            int re;
            ComplexClass complex3;
            ComplexClass complex4;
            ComplexClass resultClass;
            Console.Clear();
            PrintMsg($"/****** Действия над комплексными числами ******/", ConsoleColor.DarkYellow);
            complex3 = UserInputNums();
            complex4 = UserInputNums();

            switch (menuNum)
            {
                case 1:
                    resultClass = complex3.Plus(complex4);
                    PrintMsg($"Результат сложения комплексных чисел: {resultClass.ToString()}", ConsoleColor.DarkYellow);
                    break;
                case 2:
                    resultClass = complex3.Subtr(complex4);
                    PrintMsg($"Результат вычитания комплексных чисел: {resultClass.ToString()}", ConsoleColor.DarkYellow);
                    break;
                case 3:
                    resultClass = complex3.Multi(complex4);
                    PrintMsg($"Результат умножения комплексных чисел: {resultClass.ToString()}", ConsoleColor.DarkYellow);
                    break;
            }
            Pause();
            Console.Clear();
        }
    }
}
