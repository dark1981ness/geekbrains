using System;
using System.Collections.Generic;

namespace Less3Ex2
{
    /// <summary>
    /// Класс для расчета суммы нечетных чисел.
    /// </summary>
    class SummOdd
    {
        private int _summOdds;
        private List<int> _numList;

        public int SummOdds
        {
            get { return _summOdds; }
            set { _summOdds = value; }
        }

        public List<int> NumList
        {
            get { return _numList; }
            set { _numList = value; }
        }

        public void GetUserValue()
        {
            List<int> myList = new List<int>();
            int num;
            do
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"Введено неверное значение, попробуйте снова");
                }
                myList.Add(num);
            } while (num != 0);
            NumList = myList;
        }

        public int Sum(List<int> arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0 && arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public string ShowNumbers()
        {
            string numbers = string.Empty;
            for (int i = 0; i < NumList.Count; i++)
            {
                if (NumList[i] > 0 && NumList[i] % 2 != 0)
                {
                    numbers += (NumList[i] + " ");
                }
                
            }
            return numbers;
        }

        public void PrintMsg(string outputText, int x, int y)
        {
            ConsoleColor dfltForeground = Console.ForegroundColor;
            int leftPos = x;
            int topPos = y;
            Console.SetCursorPosition(leftPos, topPos);
            Console.WriteLine(outputText);
            Console.ForegroundColor = dfltForeground;
        }

        public void PrintMsg(string outputText, ConsoleColor foregroundcolor)
        {
            ConsoleColor dfltForeground = Console.ForegroundColor;
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(outputText);
            Console.ForegroundColor = dfltForeground;
        }

        public void Pause()
        {
            Console.ReadKey();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //а)  С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
            //Требуется подсчитать сумму всех нечётных положительных чисел.
            //Сами числа и сумму вывести на экран, используя tryParse.

            #endregion

            #region Declaring variables

            string header = "Подсчет суммы нечетных положительных чисел";
            
            SummOdd summOdd = new SummOdd();

            #endregion

            summOdd.PrintMsg(header, (Console.WindowWidth - header.Length) / 2, 0);
            Console.WriteLine();
            Console.WriteLine($"Для завершения ввода необходимо ввести цифру 0");
            Console.WriteLine($"Введите, пожалуйста, числа");
            summOdd.GetUserValue();
            summOdd.Sum(summOdd.NumList);
            summOdd.PrintMsg($"Сумма чисел {summOdd.ShowNumbers()} составляет: {summOdd.Sum(summOdd.NumList)}", ConsoleColor.Green);
            Console.WriteLine();
            Console.WriteLine($"Для выхода из программы нажмите любую клавишу.");
            summOdd.Pause();
        }
    }
}
