using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less6Ex2
{
    class InterAction
    {
        private static double min;

        public static int GetUserValue()
        {
            int num;
            do
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"Введено неверное значение, попробуйте снова");
                }
            } while (false);
            return num;
        }

        public static double CheckCoord()
        {
            double num;
            do
            {
                while (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"Введено неверное значение, попробуйте снова");
                }
            } while (false);
            return num;
        }

        public static void CaseBody(string path, FuncWithOutIndex funcWithOutIndex)
        {
            Console.Clear();
            SaveLoad.PrintMsg($"Введите начальную координату отрезка Х1", ConsoleColor.DarkYellow);
            double x1 = CheckCoord();
            SaveLoad.PrintMsg($"Введите конечную координату отрезка Х2", ConsoleColor.DarkYellow);
            double x2 = CheckCoord();
            SaveLoad.PrintMsg($"Введите величину шага", ConsoleColor.DarkYellow);
            double step = CheckCoord();
            SaveLoad.SaveFunc(path, x1, x2, step, funcWithOutIndex);
            SaveLoad.Table(SaveLoad.Load(path, out min), x1, x2, step);
            Console.WriteLine($"Минимальное значение функции = {min:f3}");
            Console.ReadKey();
            Console.Clear();

        }

        public static void CaseBody(string path, FunсWithIndex funсWithIndex)
        {
            Console.Clear();
            SaveLoad.PrintMsg($"Введите начальную координату отрезка Х1", ConsoleColor.DarkYellow);
            double x1 = CheckCoord();
            SaveLoad.PrintMsg($"Введите конечную координату отрезка Х2", ConsoleColor.DarkYellow);
            double x2 = CheckCoord();
            SaveLoad.PrintMsg($"Введите коэффициент", ConsoleColor.DarkYellow);
            double k = CheckCoord();
            SaveLoad.PrintMsg($"Введите величину шага", ConsoleColor.DarkYellow);
            double step = CheckCoord();
            SaveLoad.SaveFunc(path, x1, x2, k, step, funсWithIndex);
            SaveLoad.TableWithIndex(SaveLoad.Load(path, out min), x1, x2, step, k);
            Console.WriteLine($"Минимальное значение функции = {min:f3}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
