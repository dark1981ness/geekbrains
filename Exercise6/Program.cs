using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Program
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
            ConsoleColor dfltForeground = Console.ForegroundColor;
            int leftPos = x;
            int topPos = y;
            Console.SetCursorPosition(leftPos, topPos);
            Console.WriteLine(outputText);
            Console.ForegroundColor = dfltForeground;
        }

        public static void PrintMsg(string outputText, ConsoleColor foregroundcolor)
        {
            ConsoleColor dfltForeground = Console.ForegroundColor;
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(outputText);
            Console.ForegroundColor = dfltForeground;
        }

        public static void PrintMsg(string outputText, ConsoleColor backgroundcolor, ConsoleColor foregroundcolor)
        {
            ConsoleColor dfltForeground = Console.ForegroundColor;
            Console.BackgroundColor = backgroundcolor;
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(outputText);
            Console.ForegroundColor = dfltForeground;
        }

        public static void PrintMsg(string outputText, int x, int y, ConsoleColor foregroundcolor)
        {
            ConsoleColor dfltForeground = Console.ForegroundColor;
            int leftPos = x;
            int topPos = y;
            Console.SetCursorPosition(leftPos, topPos);
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(outputText);
            Console.ForegroundColor = dfltForeground;
        }

        public static void Pause()
        {
            Console.ReadKey();
        }

        public static long DigitsNumSum(long a)
        {
            long sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a = a / 10;
            }
            return sum;
        }

        public static int FindNums(int a)
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
