using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less6Ex2
{
    //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
    //в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
    //возвращает минимум через параметр.

    public delegate double FuncWithOutIndex(double x);
    public delegate double FunсWithIndex(double x, double a);

    class Program
    {
        private static int menuValue;
        private static string pathToFile = @"..\\..\\data\\data.bin";

        static void Main(string[] args)
        {
            MathFunc mathFunc = new MathFunc();
            List<FuncWithOutIndex> funcWithOutIndices = new List<FuncWithOutIndex> {new FuncWithOutIndex(mathFunc.CosineFunctionWithOutIndex),
                new FuncWithOutIndex(mathFunc.SinusoidFunctionWithOutIndex),
                new FuncWithOutIndex(mathFunc.QuadraticFunctionWithOutIndex),
                new FuncWithOutIndex(mathFunc.CubicFunctionWithOutIndex)};
            List<FunсWithIndex> funсWithIndices = new List<FunсWithIndex> {new FunсWithIndex(mathFunc.CosFunction),
                new FunсWithIndex(mathFunc.SinusoidFunction),
                new FunсWithIndex(mathFunc.QuadraticFunction)};
            #region Menu
            do
            {
                SaveLoad.PrintMsg($"/****** Программа нахождения минимума функции ******/", ConsoleColor.DarkYellow);
                SaveLoad.PrintMsg($"1. f(x) = x^2", ConsoleColor.DarkYellow);
                SaveLoad.PrintMsg($"2. f(x) = x^3", ConsoleColor.DarkYellow);
                SaveLoad.PrintMsg($"3. f(x) = sin(x)", ConsoleColor.DarkYellow);
                SaveLoad.PrintMsg($"4. f(x) = cos(x)", ConsoleColor.DarkYellow);
                SaveLoad.PrintMsg($"5. f(x) = a*x^2", ConsoleColor.DarkYellow);
                SaveLoad.PrintMsg($"6. f(x) = a*sin(x)", ConsoleColor.DarkYellow);
                SaveLoad.PrintMsg($"7. f(x) = a*cos(x)", ConsoleColor.DarkYellow);
                SaveLoad.PrintMsg($"0. Выход из программы", ConsoleColor.DarkYellow);
                menuValue = InterAction.GetUserValue();
                switch (menuValue)
                {
                    case 1:
                        InterAction.CaseBody(pathToFile, funcWithOutIndices[2]);
                        break;
                    case 2:
                        InterAction.CaseBody(pathToFile, funcWithOutIndices[3]);
                        break;
                    case 3:
                        InterAction.CaseBody(pathToFile, funcWithOutIndices[1]);
                        break;
                    case 4:
                        InterAction.CaseBody(pathToFile, funcWithOutIndices[0]);
                        break;
                    case 5:
                        InterAction.CaseBody(pathToFile, funсWithIndices[2]);
                        break;
                    case 6:
                        InterAction.CaseBody(pathToFile, funсWithIndices[1]);
                        break;
                    case 7:
                        InterAction.CaseBody(pathToFile, funсWithIndices[0]);
                        break;
                    case 0:
                        Environment.Exit(-1);
                        break;
                }

            } while (menuValue != 0);
            #endregion
        }
    }
}
