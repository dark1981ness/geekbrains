using System;
using static Exercise6.Program;

namespace Less2Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.

            #endregion

            #region Declaring variables

            string header = "Подсчет суммы нечетных положительных чисел";
            ConsoleColor dfltForeground = Console.ForegroundColor;
            int summ = 0;
            int num;
            #endregion

            PrintMsg(header, (Console.WindowWidth - header.Length) / 2, 0);
            Console.WriteLine();
            Console.WriteLine($"Для завершения ввода необходимо ввести цифру 0");
            Console.WriteLine($"Введите, пожалуйста, числа");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"Введено неверное значение, попробуйте снова");
                }

                if (num > 0 && num % 2 != 0)
                {
                    summ += num;
                }
            } while (num != 0);

            PrintMsg($"Сумма нечетных чисел составляет: {summ}", ConsoleColor.Green);
            Console.WriteLine();
            Console.ForegroundColor = dfltForeground;
            Console.WriteLine($"Для выхода из программы нажмите любую клавишу.");
            Pause();
        }
    }
}
