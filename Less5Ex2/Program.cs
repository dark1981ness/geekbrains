using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Less5Ex2
{
    //Разработать класс Message, содержащий следующие статические методы для обработки
    //текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //Продемонстрируйте работу программы на текстовом файле с вашей программой.
    class Message
    {
        public static List<string> GetWordsByLength(string msg, int n)
        {
            
            List<string> result = new List<string>();
            char[] charSeparators = new char[] { ' ', '.', ',', '-', '\n', '\t', '\r'};
            string[] wordsArray = msg.Split(charSeparators);
            foreach (var item in wordsArray)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    result.Add(item);
                }
            }

            wordsArray = result.ToArray();
            result.Clear();
            for(int i = 0; i < wordsArray.Length; i++)
            {
                if(wordsArray[i].Length <= n)
                {
                    result.Add(wordsArray[i]);
                }
            }

            return result;
        }

        public static string RemoveWordByChar(string msg, char ch)
        {
            List<string> result = new List<string>();
            char[] charSeparators = new char[] { ' ', '.', ',', '-', '\n', '\t', '\r' };
            string[] wordsArray = msg.Split(charSeparators);
            foreach (var item in wordsArray)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    result.Add(item);
                }
            }
           
            for (int i = 0; i < result.Count; i++)
            {
                if(result[i][result[i].Length - 1] == ch)
                {
                    msg = msg.Replace(result[i], "");
                }
            }

            return msg;
        }

        public static List<string> GetLongestWord(string msg)
        {
            List<string> result = new List<string>();
            char[] charSeparators = new char[] { ' ', '.', ',', '-', '\n', '\t', '\r' };
            string[] wordsArray = msg.Split(charSeparators);
            foreach (var item in wordsArray)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    result.Add(item);
                }
            }

            wordsArray = result.ToArray();
            result.Clear();
            int max = wordsArray[0].Length;
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (wordsArray[i].Length > max)
                {
                    max = wordsArray[i].Length;
                } 
            }

            for (int i = 0; i < wordsArray.Length; i++)
            {
                if(wordsArray[i].Length == max)
                {
                    result.Add(wordsArray[i]);
                }
            }
            return result;
        }

        public static StringBuilder BuildString(string msg)
        {
            List<string> tempList = GetLongestWord(msg);
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var item in tempList)
            {
                stringBuilder.Append(item).Append(" ");
            }

            return stringBuilder;
        }

        public static void PrintList(List<string> myList)
        {
            foreach(var item in myList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string myMessage = "Пока размотала длиннющий шарф перед зеркалом на колонне, успела взмокнуть";

            List<string> aEx = Message.GetWordsByLength(myMessage, 6);
            Message.PrintList(aEx);
            Console.WriteLine();
            myMessage = Message.RemoveWordByChar(myMessage, 'а');
            Console.WriteLine($"{myMessage}");
            Console.WriteLine();
            List<string> longWords = Message.GetLongestWord(myMessage);
            Message.PrintList(longWords);
            Console.WriteLine();
            Console.WriteLine($"Строка из длинных слов \"{Message.BuildString(myMessage)}\"");
            Console.ReadKey();
        }
    }
}
