using System;
using static Exercise6.Program;

namespace Less2Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b);
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

            #endregion

            #region Declaring variables

            int a;
            int b;
            string header = "Развлекаемся с рекурсивными методами";
            ConsoleColor dfltForeground = Console.ForegroundColor;

            #endregion

            PrintMsg(header, (Console.WindowWidth - header.Length) / 2, 0);
            Console.WriteLine();
            Console.WriteLine($"Введите диапазон чисел");
            Console.Write($"Первое число диапазона: ");

            while(!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine($"Введено неверное значение, попробуйте снова");
            }

            Console.Write($"Последнее число диапазона: ");

            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine($"Введено неверное значение, попробуйте снова");
            }

            Console.WriteLine($"Числа входящие в диапазон {a} - {b}");
            OutputNumbers(a, b);
            Console.WriteLine();
            Console.ForegroundColor = dfltForeground;
            Console.WriteLine($"Сумма чисел диапазона {a} - {b}");
            PrintMsg($"{OutputNumbersSum(a, b)}", ConsoleColor.DarkYellow);
            Pause();
        }

        private static void OutputNumbers(int a, int b)
        {
            PrintMsg($"{a}", ConsoleColor.DarkYellow);
            if (a < b) OutputNumbers(a + 1, b);
        }

        private static int OutputNumbersSum(int a, int b)
        {
            if (a <= b)
                return OutputNumbersSum(a + 1, b) + a;
            else
                return 0;
        }
    }
}
