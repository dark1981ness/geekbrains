using System;
using static Exercise6.Program;

namespace Less2Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //а) Написать программу, которая запрашивает массу и рост человека,
            //   вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
            //   набрать вес или все в норме;
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            #endregion

            #region Declaring variables
            double height;
            ushort weight;
            double bmi;
            string textOutput = "Добро пожаловать в программу антропометрических данных";
            ConsoleColor dfltForeground = Console.ForegroundColor;
            #endregion


            Console.SetCursorPosition(((Console.WindowWidth - textOutput.Length) / 2), Console.CursorTop);
            Console.WriteLine(textOutput);
            Console.WriteLine();
            Console.Write("Введите массу тела в килограммах: ");

            while (!UInt16.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine($"Введено неверное значение, попробуйте снова");
            }

            Console.Write("Введите свой рост в метрах: ");

            while (!Double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine($"Введено неверное значение, попробуйте снова");
            }

            bmi = BMI(height, weight);

            Console.WriteLine($"Индекс массы тела составляет: {bmi}");
            Console.Write($"Ваше состояние здоровья, согласно таблице интерпритации показателей ИМТ: ");
            VerificationBMI(bmi);
            Console.ForegroundColor = dfltForeground;
            WeightControl(height, weight, bmi);
            Pause();
        }

        private static double BMI(double height, ushort weight)
        {
            double bmi = 0;
            bmi = Math.Round((weight / Math.Pow(height, 2)), 2);
            return bmi;
        }

        private static void VerificationBMI(double bmi)
        {
            if (bmi <= 16)
            {
                PrintMsg("Выраженный дефицит массы тела", ConsoleColor.Red);
            }
            else if (bmi > 16 && bmi <= 18.5)
            {
                PrintMsg("Недостаточная (дефицит) масса тела", ConsoleColor.Yellow);
            }
            else if (bmi > 18.5 && bmi <= 25)
            {
                PrintMsg("Норма", ConsoleColor.Green);
            }
            else if (bmi > 25 && bmi <= 30)
            {
                PrintMsg("Избыточная масса тела (предожирение)", ConsoleColor.Yellow);
            }
            else if (bmi > 30 && bmi <= 35)
            {
                PrintMsg("Ожирение", ConsoleColor.DarkYellow);
            }
            else if (bmi > 35 && bmi <= 40)
            {
                PrintMsg("Ожирение резкое", ConsoleColor.Red);
            }
            else if (bmi > 40)
            {
                PrintMsg("Очень резкое ожирение", ConsoleColor.DarkRed);
            }
        }

        private static void WeightControl(double height, ushort weight, double bmi)
        {
            double bBMI = 18.5;
            double eBMI = 25;
            double averegeBMI = (bBMI + eBMI) / 2;
            double standartWeight = Math.Pow(height, 2) * averegeBMI;
            if(bmi < 18.5)
            {
                double diffWeight = standartWeight - weight;
                Console.WriteLine($"Для нормализации веса необходимо набрать, примерно {diffWeight:f2} кг");
            }
            else if(bmi > 25)
            {
                double diffWeight = weight - standartWeight;
                Console.WriteLine($"Для нормализации веса необходимо сбросить, примерно {diffWeight:f2} кг");
            }
            
        }
    }
}
