using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //*Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

            #endregion
        }

        public static void PrintMsg(string outputText, int x, int y)
        {
            int leftPos = x;
            int topPos = y;
            Console.SetCursorPosition(leftPos, topPos);
            Console.WriteLine(outputText);
        }

        public static void PrintMsg(string outputText, ConsoleColor foregroundcolor)
        {
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(outputText);
        }

        public static void PrintMsg(string outputText, ConsoleColor backgroundcolor, ConsoleColor foregroundcolor)
        {
            Console.BackgroundColor = backgroundcolor;
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(outputText);
        }

        public static void PrintMsg(string outputText, int x, int y, ConsoleColor foregroundcolor)
        {
            int leftPos = x;
            int topPos = y;
            Console.SetCursorPosition(leftPos, topPos);
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(outputText);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
