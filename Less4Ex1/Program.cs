using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less4Ex1
{
    #region Task

    // выполнил - Noskov Konstantin
    //
    //Дан целочисленный массив из 20 элементов.
    //Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
    //Написать программу, позволяющую найти и вывести количество пар элементов массива,
    //в которых хотя бы одно число делится на 3.
    //В данной задаче под парой подразумевается два подряд идущих элемента массива.
    //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

    #endregion
    class MyArray
    {
        private int[] a;

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        /// <summary>
        /// Создание массива с заполнением случайными числами в заданном диапазоне.
        /// </summary>
        public MyArray(int n, int firstNum, int lastNum)
        {
            a = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(firstNum, lastNum);
            }
        }

        /// <summary>
        /// метод проверки деления на "3" пар элементов массива.
        /// пары проверяются по следующей логике {a[0]a[1]}, {a[1]a[2]}
        /// </summary>
        /// <returns>количество пар</returns>
        public int DivBy3VerOne()
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0 || a[i + 1] % 3 == 0)
                {
                    if(a[i] % 3 == 0)
                        PrintMsg($"Элемент \"{a[i]}\", из пары \"{a[i]}\" - \"{a[i +1]}\", делится на \"3\"", ConsoleColor.DarkYellow);
                    else
                        PrintMsg($"Элемент \"{a[i + 1]}\", из пары \"{a[i]}\" - \"{a[i + 1]}\", делится на \"3\"", ConsoleColor.DarkYellow);
                    count++;
                }
            }
            Console.WriteLine();
            PrintMsg($"Количество пар элементов делящихся на \"3\" : {count}", ConsoleColor.DarkYellow);
            return count;
        }

        /// <summary>
        /// метод проверки деления на "3" пар элементов массива.
        /// пары проверяются по следующей логике {a[0]a[1]}, {a[2]a[3]}
        /// </summary>
        /// <returns>количество пар</returns>
        public int DivBy3VerTwo()
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i += 2)
            {
                if (a[i] % 3 == 0 || a[i + 1] % 3 == 0)
                {
                    if (a[i] % 3 == 0)
                        PrintMsg($"Элемент \"{a[i]}\", из пары \"{a[i]}\" - \"{a[i + 1]}\", делится на \"3\"", ConsoleColor.DarkYellow);
                    else
                        PrintMsg($"Элемент \"{a[i + 1]}\", из пары \"{a[i]}\" - \"{a[i + 1]}\", делится на \"3\"", ConsoleColor.DarkYellow);
                    count++;
                }
            }
            Console.WriteLine();
            PrintMsg($"Количество пар элементов делящихся на \"3\" : {count}", ConsoleColor.DarkYellow);
            return count;
        }

        /// <summary>
        /// переопределение метода ToString() для вывода значений массива
        /// в строковом формате.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string arrayOutput = string.Empty;
            foreach (int arrayItem in a)
            {
                arrayOutput = arrayOutput + arrayItem + " ";
            }
            return arrayOutput;
        }

        public void PrintMsg(string outputText, ConsoleColor foregroundcolor)
        {
            ConsoleColor dfltForeground = Console.ForegroundColor;
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(outputText);
            Console.ForegroundColor = dfltForeground;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray(20, -10_000, 10_000);
            myArray.PrintMsg($"Массив элементов, заполненый случайными числами\n", ConsoleColor.DarkYellow);
            myArray.PrintMsg(myArray.ToString(), ConsoleColor.DarkYellow);
            Console.WriteLine();
            myArray.DivBy3VerOne();
            Console.WriteLine();
            myArray.DivBy3VerTwo();
            Console.ReadKey();
        }
    }
}
