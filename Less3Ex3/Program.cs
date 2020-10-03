using System;
using static Exercise6.Program;

namespace Less3Ex3
{
    #region task 

    // выполнил - Noskov Konstantin
    //
    //задача:
    //* Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    //* Добавить свойства типа int для доступа к числителю и знаменателю;
    //* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    //*** Добавить упрощение дробей.


    #endregion
    class RationalNumber
    {
        private int _az;
        private int _bn;
        private double _dfrac;

        public int AZ
        {
            get { return _az; }
            set { _az = value; }
        }

        public int BN
        {
            get { return _bn; }
            set 
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                _bn = value;
                
            }
        }

        public double DFRAC
        {
            get { return _dfrac; }
        }

        public RationalNumber(int az, int bn)
        {
            AZ = az;
            BN = bn;
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            RationalNumber result = new RationalNumber(1, 1);
            if(a._bn == b._bn)
            {
                result._bn = a._bn;
                result._az = a._az + b._az;
            }else if(Math.Max(a._bn, b._bn) % Math.Min(a._bn,b._bn) == 0)
            {
                result._bn = Math.Max(a._bn, b._bn);
                if(Math.Max(a._bn, b._bn) == a._bn)
                {
                    result._az = (Math.Max(a._bn, b._bn) / Math.Min(a._bn, b._bn)) * a._az + b._az;
                }
                else
                {
                    result._az = (Math.Max(a._bn, b._bn) / Math.Min(a._bn, b._bn)) * b._az + a._az;
                }
            }
            else
            {
                result._bn = a._bn * b._bn;
                result._az = (a._az * b._bn) + (b._az * a._bn);
            }
            return result;
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            RationalNumber result = new RationalNumber(1, 1);
            if (a._bn == b._bn)
            {
                result._bn = a._bn;
                result._az = a._az - b._az;
            }
            else if (Math.Max(a._bn, b._bn) % Math.Min(a._bn, b._bn) == 0)
            {
                result._bn = Math.Max(a._bn, b._bn);
                if (Math.Max(a._bn, b._bn) == a._bn)
                {
                    result._az = (Math.Max(a._bn, b._bn) / Math.Min(a._bn, b._bn)) * a._az - b._az;
                }
                else
                {
                    result._az = (Math.Max(a._bn, b._bn) / Math.Min(a._bn, b._bn)) * b._az - a._az;
                }
            }
            else
            {
                result._bn = a._bn * b._bn;
                result._az = (a._az * b._bn) - (b._az * a._bn);
            }
            return result;
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            RationalNumber result = new RationalNumber(1, 1);
            result._az = a._az * b._az;
            result._bn = a._bn * b._bn;
            return result;
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            RationalNumber result = new RationalNumber(1, 1);
            result._az = a._az * b._bn;
            result._bn = a._bn * b._az;
            return result;
        }

        public double ConvertToDecimal(int az, int bn)
        {
            _dfrac = (double)az / (double)bn;
            return _dfrac;
        }

        public int Nod(int az, int bn)
        {

            az = Math.Abs(az);
            bn = Math.Abs(bn);
            while (az != bn)
            {
                if (az > bn)
                {
                    az = az - bn;
                }
                else
                {
                    bn = bn - az;
                }
            }
            return az;

        }

        public override string ToString()
        {
            return string.Format($"{_az} / {_bn}");
        }

        
    }
    class Program
    {
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

        private static RationalNumber UserInputNums()
        {
            int az, bn;
            PrintMsg($"Введите числитель:", ConsoleColor.DarkYellow);
            az = GetUserValue();
            PrintMsg($"Введите знаменатель:", ConsoleColor.DarkYellow);
            bn = GetUserValue();
            return _ = new RationalNumber(az, bn);
        }

        private static void OperationComplexNum(int menuNum)
        {
            int az;
            int bn;
            RationalNumber ratNumFirst;
            RationalNumber ratNumSecond;
            RationalNumber resultClass;
            Console.Clear();
            PrintMsg($"/****** Действия над рациональными числами ******/", ConsoleColor.DarkYellow);
            ratNumFirst = UserInputNums();
            ratNumSecond = UserInputNums();

            switch (menuNum)
            {
                case 1:
                    resultClass = ratNumFirst + ratNumSecond;
                    PrintMsg($"Результат сложения чисел: {resultClass.ToString()}", ConsoleColor.DarkYellow);
                    //Упрощение дробей
                    int nod = resultClass.Nod(resultClass.AZ, resultClass.BN);
                    resultClass.AZ = resultClass.AZ / nod;
                    resultClass.BN = resultClass.BN / nod;
                    PrintMsg($"Упрощение дроби после операции сложения: {resultClass.ToString()}", ConsoleColor.DarkYellow);
                    //Получение десятичной дроби числа
                    resultClass.ConvertToDecimal(resultClass.AZ, resultClass.BN);
                    PrintMsg($"Десятичная дробь числа: {resultClass.DFRAC}", ConsoleColor.DarkYellow);
                    break;
                case 2:
                    resultClass = ratNumFirst - ratNumSecond;
                    PrintMsg($"Результат вычитания чисел: {resultClass.ToString()}", ConsoleColor.DarkYellow);
                    break;
                case 3:
                    resultClass = ratNumFirst * ratNumSecond;
                    PrintMsg($"Результат умножения чисел: {resultClass.ToString()}", ConsoleColor.DarkYellow);
                    break;
                case 4:
                    resultClass = ratNumFirst / ratNumSecond;
                    PrintMsg($"Результат деления чисел: {resultClass.ToString()}", ConsoleColor.DarkYellow);
                    break;
            }
            Pause();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            do
            {
                PrintMsg($"/****** Действия над рациональными числами ******/", ConsoleColor.DarkYellow);
                PrintMsg($"1. Сложение", ConsoleColor.DarkYellow);
                PrintMsg($"2. Вычитание", ConsoleColor.DarkYellow);
                PrintMsg($"3. Умножение", ConsoleColor.DarkYellow);
                PrintMsg($"4. Деление", ConsoleColor.DarkYellow);
                PrintMsg($"5. Выход из программы", ConsoleColor.DarkYellow);
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
                        OperationComplexNum(4);
                        break;
                    case 5:
                        Environment.Exit(-1);
                        break;
                }

            } while (menuValue != 5);

            Console.ReadKey();
        }
    }
}
