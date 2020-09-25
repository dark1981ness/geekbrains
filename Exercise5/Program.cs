using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.
            //в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            #endregion


            #region Declaring variables

            string name;
            string surName;
            string city;
            string textOutput;
            int x;
            int y;

            #endregion

            name = "Константин";
            surName = "Носков";
            city = "Санкт-Петербург";

            textOutput = name + " " + surName + " " + city;

            #region A

            Console.WriteLine($"{name} {surName} {city}");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region B

            Console.SetCursorPosition(((Console.WindowWidth - textOutput.Length) / 2), Console.WindowHeight / 2 );
            Console.WriteLine($"{ textOutput}");
            Console.ReadKey();
            Console.Clear();

            #endregion

            #region C

            x = ((Console.WindowWidth - textOutput.Length) / 2);
            y = Console.WindowHeight / 2;
            PrintMsg(textOutput, x, y, ConsoleColor.Green);
            Pause();

            #endregion
        }

        private static void PrintMsg(string outputText, int x, int y, ConsoleColor foregroundcolor)
        {
            int leftPos = x;
            int topPos = y;
            Console.SetCursorPosition(leftPos, topPos);
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine($"{outputText}");
        }

        private static void Pause()
        {
            Console.ReadKey();
        }
    }
}
