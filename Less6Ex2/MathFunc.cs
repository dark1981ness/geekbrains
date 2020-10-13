using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less6Ex2
{
    class MathFunc
    {

        public MathFunc()
        {

        }

        public double QuadraticFunctionWithOutIndex(double x)
        {
            return Math.Pow(x, 2);
        }

        public double CubicFunctionWithOutIndex(double x)
        {
            return Math.Pow(x, 3);
        }

        public double SinusoidFunctionWithOutIndex(double x)
        {
            return Math.Sin(x);
        }

        public double CosineFunctionWithOutIndex(double x)
        {
            return Math.Cos(x);
        }

        public double QuadraticFunction(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }

        public double SinusoidFunction(double x, double a)
        {
            return a * Math.Sin(x);
        }

        public double CosFunction(double x, double a)
        {
            return a * Math.Cos(x);
        }

    }
}
