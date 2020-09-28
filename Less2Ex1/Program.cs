using System;
using static Exercise6.Program;

namespace Less2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //Написать метод, возвращающий минимальное из трёх чисел.

            #endregion

            #region Declaring variables
            string header = "Поиск минимального значения тз трех чисел";
            int x;
            int y;
            int z;

            #endregion

            PrintMsg(header, (Console.WindowWidth - header.Length) / 2, 0);
            Console.WriteLine();
            Console.WriteLine($"Введите первое число");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine($"Введено неверное значение, попробуйте снова");
            }

            Console.WriteLine($"Введите второе число");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine($"Введено неверное значение, попробуйте снова");
            }

            Console.WriteLine($"Введите третье число");
            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine($"Введено неверное значение, попробуйте снова");
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальное число - {GetMin(x, y, z)}");
            Console.WriteLine($"Минимальное число с использованием класса \"Math\" - {GetMinWithMath(x, y, z)}");
            Pause();
        }

        private static int GetMin(int a, int b, int c)
        {
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            return min;
        }

        private static int GetMinWithMath(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
