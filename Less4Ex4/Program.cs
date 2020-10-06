using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less4Ex4
{
    #region Task

    // выполнил - Noskov Konstantin
    //
    //* а) Реализовать класс для работы с двумерным массивом.
    //     Реализовать конструктор, заполняющий массив случайными числами.
    //     Создать методы, которые возвращают сумму всех элементов массива,
    //     сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива,
    //     свойство, возвращающее максимальный элемент массива,
    //     метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
    //* б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    //Дополнительные задачи
    //  в) Обработать возможные исключительные ситуации при работе с файлами.

    #endregion


    class MyArray
    {
        private int[,] a;
        private int _maxValue;
        private int _minValue;

        public int MaxValue
        {
            get
            {
                _maxValue = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > _maxValue) _maxValue = a[i, j];
                    }
                }
                return _maxValue;
            }
        }

        public int MinValue
        {
            get
            {
                _minValue = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < _minValue) _minValue = a[i, j];
                    }
                }
                return _minValue;
            }
        }

        /// <summary>
        /// Создание массива с заполнением случайными числами в заданном диапазоне.
        /// </summary>
        public MyArray(int n, int m)
        {
            a = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = random.Next(-100, 100);
                }
                
            }
        }

        public MyArray()
        {

        }

        public void Sum(out int sum)
        {
            sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
        }

        public void SumGreaterThen(int n, int m, out int sum)
        {
            sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(a[i, j] > a[n, m])
                    {
                        sum += a[i, j];
                    }
                    
                }
            }
        }

        public void MaxElemIndex(out string index)
        {
            string tempIndex;
            index = string.Empty;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(a[i, j] == _maxValue){
                        tempIndex = $"<{i},{j}>";
                        index += tempIndex;
                    }
                }
            }
        }

        /// <summary>
        /// чтение данных из файла
        /// </summary>
        /// <param name="filePath">путь до файла</param>
        public void ReadFromFile(string filePath)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    string[] tempLength = streamReader.ReadLine().Split('/');
                    int n = int.Parse(tempLength[0]);
                    int m = int.Parse(tempLength[1]);
                    a = new int[n, m];
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        string[] tempRow = streamReader.ReadLine().Split(' ');
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            a[i, j] = int.Parse(tempRow[j]);
                        }

                    }
                }
            }
            catch (FileNotFoundException)
            {
                PrintMsg($"Файл конфиуграции отсутствует по указанному пути: {filePath}", ConsoleColor.Red);
            }
            catch(IOException ex)
            {
                PrintMsg($"{ex.Message}", ConsoleColor.Red);
            }
            
        }

        /// <summary>
        /// Сохранение массива в файл
        /// </summary>
        /// <param name="filePath">путь до файла</param>
        public void SaveToFile(string filePath)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine(a.GetLength(0) + "/" + a.GetLength(1));
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            streamWriter.Write(a[i, j] + " ");
                        }
                        streamWriter.WriteLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                PrintMsg($"Файл конфиуграции отсутствует по указанному пути: {filePath}", ConsoleColor.Red);
            }
            catch(IOException ex)
            {
                PrintMsg($"{ex.Message}", ConsoleColor.Red);
            }
            
        }

        /// <summary>
        /// переопределение метода ToString() для вывода значений массива
        /// в строковом формате.
        /// </summary>
        /// <returns></returns>
        public void Print2DArray(ConsoleColor foregroundcolor)
        {
            ConsoleColor dfltForeground = Console.ForegroundColor;
            Console.ForegroundColor = foregroundcolor;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j], 4}\t");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ForegroundColor = dfltForeground;
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
            ConsoleColor dflBackground = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            MyArray myArray = new MyArray(5, 5);
            myArray.PrintMsg($"Двумерный массив заполненный случайными числами в заданном диапазоне", ConsoleColor.White);
            Console.WriteLine();
            myArray.Print2DArray(ConsoleColor.Yellow);
            Console.WriteLine();
            myArray.PrintMsg($"сумма всех элементов массива", ConsoleColor.White);
            myArray.Sum(out int sum);
            myArray.PrintMsg($"{sum}", ConsoleColor.Yellow);
            Console.WriteLine();
            myArray.PrintMsg($"сумма всех элементов массива больше заданного", ConsoleColor.White);
            myArray.SumGreaterThen(0, 1, out int gSum);
            myArray.PrintMsg($"{gSum}", ConsoleColor.Yellow);
            Console.WriteLine();
            myArray.PrintMsg($"минимальное и максимальное значения массива", ConsoleColor.White);
            myArray.PrintMsg($"минимальное значение - {myArray.MinValue}", ConsoleColor.Yellow);
            myArray.PrintMsg($"максимальное значение - {myArray.MaxValue}", ConsoleColor.Yellow);
            Console.WriteLine();
            myArray.MaxElemIndex(out string index);
            myArray.PrintMsg($"Номер максимального элемента массива - {index}", ConsoleColor.White);
            Console.WriteLine();
            MyArray myArray1 = new MyArray();
            myArray1.PrintMsg($"Двумерный массив заполненный из файла", ConsoleColor.White);
            Console.WriteLine();
            myArray1.ReadFromFile(@"..\\..\\items\\array.txt");
            myArray1.Print2DArray(ConsoleColor.Yellow);
            myArray1.SaveToFile(@"..\\..\\items\\array_2.txt");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
