using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less5Ex3
{
//        * Для двух строк написать метод, определяющий,
//          является ли одна строка перестановкой другой.Регистр можно не учитывать:
//        а) с использованием методов C#;
//        б) * разработав собственный алгоритм.
//         Например:
//        badc являются перестановкой abcd.
    class Program
    {
        private static bool Permutation(string first, string second)
        {
            char[] s1 = first.ToCharArray();
            char[] s2 = second.ToCharArray();
            Array.Sort(s2);
            Array.Sort(s1);
            first = new string(s1);
            second = new string(s2);

            if (String.Compare(first, second, comparisonType: StringComparison.OrdinalIgnoreCase) == 0)
            {
                return true;
            }
            return false;
        }

        private static bool PermutationWoSharp(string first, string second)
        {
            bool equal = false;
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach (char ch in first)
            {
                int count;
                keyValuePairs.TryGetValue(ch, out count);
                count++;
                keyValuePairs[ch] = count;
            }

            Dictionary<char, int> keyValuePairs2 = new Dictionary<char, int>();
            foreach (char ch in second)
            {
                int count;
                keyValuePairs2.TryGetValue(ch, out count);
                count++;
                keyValuePairs2[ch] = count;
            }

            if (keyValuePairs.Count == keyValuePairs2.Count)
            {
                equal = true;
                foreach (var pair in keyValuePairs)
                {
                    int value;
                    if (keyValuePairs2.TryGetValue(pair.Key, out value))
                    {
                        if (value != pair.Value)
                        {
                            equal = false;
                            break;
                        }
                    }
                    else
                    {
                        equal = false;
                        break;
                    }
                }
            }

            return equal;
        }

        static void Main(string[] args)
        {
            string f = "abcdaaaa";
            string s = "cdbaaaaa";
            Console.WriteLine(Permutation(f, s));
            Console.WriteLine(PermutationWoSharp(f,s));
            Console.ReadKey();
        }

       
    }
}
