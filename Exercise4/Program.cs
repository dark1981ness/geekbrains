using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            #endregion


            #region Declaring variables

            int a;
            int b;
            int s;
            Console.ForegroundColor = ConsoleColor.Green;
            #endregion

            #region swap values of two variables A

            a = 30;
            b = 15;
            Console.WriteLine($"Обмен значений с использованием третьей переменной");
            Console.WriteLine($"Значения переменных до обмена\nA = {a} и B = {b}");
            s = a;
            a = b;
            b = s;

            Console.WriteLine($"Значения переменных после обмена\nA = {a} и B = {b}");
            #endregion

            Console.WriteLine("\n");

            #region swap values of two variables B

            Console.WriteLine($"Обмен значений без использования третьей переменной");
            Console.WriteLine($"Значения переменных до обмена\nA = {a} и B = {b}");

            a = (a + b) - (b = a);

            Console.WriteLine($"Значения переменных после обмена\nA = {a} и B = {b}");

            #endregion

            Console.ReadKey();
        }
    }
}
