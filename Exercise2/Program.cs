using System;
using System.CodeDom;
using System.Text.RegularExpressions;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //Ввести вес и рост человека.
            //Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
            //где m — масса тела в килограммах, h — рост в метрах.

            #endregion


            #region Declaring variables

            double height;
            ushort weight;
            double imt;
            string textOutput = "Добро пожаловать в программу антропометрических данных";

            #endregion


            Console.SetCursorPosition(((Console.WindowWidth - textOutput.Length) / 2), Console.CursorTop);
            Console.WriteLine(textOutput);
            Console.Write("Введите массу тела в килограммах: ");
            weight = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Введите свой рост в метрах: ");
            height = Convert.ToDouble(Console.ReadLine());
            imt = weight / Math.Pow(height, 2);
            Console.WriteLine($"Индекс массы тела составляет: {imt:f4}");
            Console.ReadKey();
        }
    }
}
