using System;
using static Exercise6.Program;

namespace Less2Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
            // «Хорошим» называется число, которое делится на сумму своих цифр.
            // Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

            #endregion

            #region Declaring variables

            DateTime start;
            DateTime finish;
            int goodNumsCount = 0;
            ConsoleColor dfltForeground = Console.ForegroundColor;

            #endregion

            start = DateTime.Now;
            for (long i = 1; i <= 1_000_000_000; i++)
            {
                if (i % DigitsNumSum(i) == 0)
                {
                    PrintMsg($"{i} \"хорошее\" число", ConsoleColor.DarkYellow);
                    goodNumsCount++;
                }
            }
            finish = DateTime.Now;
            PrintMsg($"Количество \"хороших\" чисел составило: {goodNumsCount}", dfltForeground);
            PrintMsg($"Время выполнения программы составило: {finish - start}", dfltForeground);

            Pause();
        }
    }
}
