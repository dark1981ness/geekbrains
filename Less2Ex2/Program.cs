using System;
using static Exercise6.Program;

namespace Less2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //Написать метод подсчета количества цифр числа.

            #endregion

            #region Declaring variables

            string header = "Подсчет количества цифр числа";
            ConsoleColor dfltForeground = Console.ForegroundColor;
            int a;
            #endregion

            PrintMsg(header, (Console.WindowWidth - header.Length) / 2, 0);
            Console.WriteLine();
            Console.Write($"Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine($"Введено неверное значение, попробуйте снова");
            }
            Console.WriteLine();
            PrintMsg($"Количество цифр в вашем числе: {FindNums(a)}", ConsoleColor.Green);
            Console.WriteLine();
            Console.ForegroundColor = dfltForeground;
            Console.WriteLine($"Для выхода из программы нажмите любую клавишу.");
            Pause();
        }

        private static int FindNums(int a)
        {
            int count = 0;
            int x = Math.Abs(a);

            if (x == 0)
            {
                count = 1;
            }
            else
            {
                while (x > 0)
                {
                    x = x / 10;
                    count++;
                }
            }
            return count;
        }
    }
}
