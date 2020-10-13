using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less6Ex1
{
    //Изменить программу вывода функции так,
    //чтобы можно было передавать функции типа double (double, double).
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    public delegate double Fun(double x, double a);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Таблица функции a*x^2");
            Table(QuadraticFunction, 2, -4, 4);
            Console.WriteLine();
            Console.WriteLine($"Таблица функции a*sin(x)");
            Table(SinusoidFunction, 2, -4, 4);
        }

        /// <summary>
        /// метод вывода таблицы функции
        /// </summary>
        /// <param name="F">делегат</param>
        /// <param name="a">амплитуда</param>
        /// <param name="x">начало отрезка</param>
        /// <param name="b">конец отрезка</param>
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine($"---- A ----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine($"| {a,6:f3} | {x,6:f3} | {F(x, a),6:f3} |");
                x += 1;
            }
            Console.WriteLine($"----------------------------");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">координата на оси абсцисс</param>
        /// <param name="a">коэффициент функции</param>
        /// <returns></returns>
        public static double QuadraticFunction(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">координата на оси абсцисс</param>
        /// <param name="a">амплитуда</param>
        /// <returns></returns>
        public static double SinusoidFunction(double x, double a)
        {
            return a * Math.Sin(x);
        }
    }
}
