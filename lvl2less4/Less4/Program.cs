using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Less4
{
    /// <summary>
    /// Класс для вспомогательных методов
    /// </summary>
    public static class Ext
    {
        /// <summary>
        /// Вспомогательный метод для подсчета одинаковых элементов в коллекции
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myNum"></param>
        /// <returns></returns>
        public static Dictionary<T, int> UniquesValues<T>(this ICollection<T> myNum)
        {
            Dictionary<T, int> keyValuePairs = new Dictionary<T, int>();

            foreach (T num in myNum)
            {
                if (keyValuePairs.ContainsKey(num))
                {
                    keyValuePairs[num]++;
                }
                else
                {
                    keyValuePairs[num] = 1;
                }
            }

            return keyValuePairs;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ex2();
            //Ex3();
        }

        private static void Ex3()
        {
           
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"four",4 },
                {"two",2 },
                { "one",1 },
                {"three",3 },
            };
            var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; });
            foreach (var pair in d)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            Console.WriteLine();
            Console.WriteLine($"обращение к OrderBy с использованием лямбда-выражения\n");
            var a = dict.OrderBy(pair => pair.Value);
            foreach (var pair in a)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            Console.WriteLine();
            Console.WriteLine($"*Развернуть обращение к OrderBy с использованием делегата \n");
            int myPredicate(KeyValuePair<string, int> pair) => pair.Value;
            Func<KeyValuePair<string, int>, int> func = myPredicate;
            var c = dict.OrderBy(func);
            foreach (var pair in c)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }

        //Дана коллекция List<T>, требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции:
        //а) для целых чисел;
        //б) *для обобщенной коллекции;
        //в) *используя Linq.
        private static void Ex2()
        {
            List<int> myNum = new List<int>() { 1, 2, 5, 6, 7, 8, 9, 2, 2, 3, 3, 4, 5, 5, 6, 7, 8, 7, 7, 7, 13 };
            var keyValuePairs = myNum.UniquesValues();
            foreach (var myitem in keyValuePairs)
            {
                Console.WriteLine($"Число {myitem.Key} встречается {myitem.Value} раз");
            }

            Console.WriteLine();
            Console.WriteLine($"ввввввввввввв\n");
            foreach (int num in myNum.Distinct())
            {
                Console.WriteLine($"Число {num} встречается {myNum.Where(x => x == num).Count()} раз");
            }

            Console.WriteLine();
            List<string> stringList = new List<string>() {
                "adf", "dgs", "asd", " adf", "0afs9", "gfd23", "adf", "asdf"
            };
            var keyValuePairsString = stringList.UniquesValues();
            foreach (var myitem in keyValuePairsString)
            {
                Console.WriteLine($"Число {myitem.Key} встречается {myitem.Value} раз");
            }
        }
    }
}
