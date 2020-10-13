using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less6Ex2
{
    class SaveLoad
    {
        
        public static void Table(List<double> values, double x1, double x2, double step)
        {
            int index = 0;
            Console.WriteLine($" ----- X ----- Y -----");
            while (x1 <= x2)
            {
                Console.WriteLine($"| {x1,6:f3} | {values[index],6:f3} |");
                x1 += step;
                index++;
            }
            Console.WriteLine($"---------------------");

        }

        public static void TableWithIndex(List<double> values, double x1, double x2, double step, double a)
        {
            int index = 0;
            Console.WriteLine($"---- A ----- X ----- Y -----");
            while (x1 <= x2)
            {
                Console.WriteLine($"| {a,6:f3} | {x1,6:f3} | {values[index],6:f3} |");
                x1 += step;
                index++;
            }
            Console.WriteLine($"----------------------------");

        }

        public static void SaveFunc(string path, double a, double b, double k, double step, FunсWithIndex FunсWith)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(FunсWith(x, k));
                x += step;
            }
            bw.Close();
            fs.Close();
        }

        public static void SaveFunc(string path, double a, double b, double step, FuncWithOutIndex FuncWithOut)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(FuncWithOut(x));
                x += step;
            }
            bw.Close();
            fs.Close();
        }

        public static List<double> Load(string path, out double min)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            List<double> values = new List<double>();
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                values.Add(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return values;
        }

        public static void PrintMsg(string outputText, ConsoleColor foregroundcolor)
        {
            ConsoleColor dfltForeground = Console.ForegroundColor;
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(outputText);
            Console.ForegroundColor = dfltForeground;
        }
    }
}
