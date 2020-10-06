using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less4Ex2
{
    #region Task

    // выполнил - Noskov Konstantin
    //
    //а) Дописать класс для работы с одномерным массивом.Реализовать конструктор,
    //   создающий массив заданной размерности и заполняющий массив числами от начального значения
    //   с заданным шагом.Создать свойство Sum, которые возвращают сумму элементов массива,
    //   метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива
    //   на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
    //   В Main продемонстрировать работу класса.
    //б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

    #endregion

    class MyArray
    {
        private int[] a;
        private double _sum;
        private int _maxValue;
        private int _maxCount;

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }


        /// <summary>
        /// Свойство, возвращающее сумму элментов одномерного массива
        /// </summary>
        public double Sum
        {
            get 
            { 
                for(int i = 0; i < a.Length; i++)
                {
                    _sum += a[i];
                }
                return _sum;
            }
        }

        public int MaxValue
        {
            get
            {
                _maxValue = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > _maxValue) _maxValue = a[i];
                }
                return _maxValue;
            }
        }

        public int MaxCount
        {
            get
            {
                _maxCount = 0;
                for(int i = 0; i<a.Length; i++)
                {
                    if (a[i] == _maxValue) _maxCount++;
                }
                return _maxCount;
            }
        }

        /// <summary>
        /// конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="n">Размерность массива</param>
        /// <param name="startNum">Значение первого элемента в массиве</param>
        /// <param name="increment">шаг</param>
        public MyArray(int n, int startNum, int increment)
        {
            a = new int[n];
            a[0] = startNum;
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i - 1] + increment;
            }
        }

        public MyArray()
        {

        }

        /// <summary>
        /// метод, меняющий знаки у всех элементов массива
        /// </summary>
        /// <returns></returns>
        public int[] Inverse()
        {
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * (-1);
            }
            return a;
        }

        /// <summary>
        /// метод, умножающий каждый элемент массива на определенное число
        /// </summary>
        /// <param name="x">множитель</param>
        /// <returns></returns>
        public int[] Multi(int x)
        {
            for(int i = 0; i < a.Length; i++)
            {
                a[i] *= x;
            }
            return a;
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
        /// метод проверки деления на "3" пар элементов массива.
        /// пары проверяются по следующей логике {a[0]a[1]}, {a[2]a[3]}
        /// </summary>
        /// <returns> количество пар</returns>
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
        /// чтение данных из файла
        /// </summary>
        /// <param name="filePath">путь до файла</param>
        /// <returns>целочисленный массив</returns>
        public int[] ReadFromFile(string filePath)
        {
            using(StreamReader streamReader = new StreamReader(filePath))
            {
                int n = int.Parse(streamReader.ReadLine());
                a = new int[n];
                string[] temp = streamReader.ReadLine().Split(';');
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(temp[i]);
                }
            }
            return a;
        }

        /// <summary>
        /// Сохранение массива в файл
        /// </summary>
        /// <param name="filePath">путь до файла</param>
        public void SaveToFile(string filePath)
        {
            using(StreamWriter streamWriter = new StreamWriter(filePath))
            {
                var tempString = string.Join(";", a);
                streamWriter.WriteLine(a.Length);
                streamWriter.WriteLine(tempString);
            }
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

            MyArray myArray = new MyArray(10, -5, 5);
            Console.WriteLine(myArray.ToString());
            double mySum = myArray.Sum;
            Console.WriteLine(mySum);
            myArray.Inverse();
            Console.WriteLine(myArray.ToString());
            Console.WriteLine();
            myArray.Multi(2);
            Console.WriteLine(myArray.ToString());
            int max = myArray.MaxValue;
            Console.WriteLine(max);
            Console.WriteLine();
            int maxCount = myArray.MaxCount;
            Console.WriteLine(maxCount);

            //Чтение данных из файла
            MyArray myArray1 = new MyArray();
            myArray1.ReadFromFile(@"..\\..\\items\\array.txt");
            Console.WriteLine(myArray1.ToString());

            //запись данных в файл
            MyArray myArray2 = new MyArray(10, -5, 5);
            myArray2.SaveToFile(@"..\\..\\items\\array_2.txt");
            Console.ReadKey();

        }
        
    }
}
