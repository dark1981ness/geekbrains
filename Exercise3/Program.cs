using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            //   по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //   Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


            #endregion


            #region Declaring variables

            double x1;
            double y1;
            double x2;
            double y2;
            double r;

            #endregion

            Console.WriteLine("Введите координаты двух точек");
            Console.Write("координата X первой точки: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("координата Y первой точки: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("координата Х второй точки: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("координата Y второй точки: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            r = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine($"Расстояние между точками = {r:f2}");
            Console.WriteLine($"Расстояние между точками (метод) = {DisBetweenPoints(x1, y1, x2, y2):f2}");
            Console.ReadKey();
        }

        private static double DisBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double range = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            return range;
        }
    }
}
