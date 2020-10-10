using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less5Ex4
{

    //    * На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
    //школы.В первой строке сообщается количество учеников N, которое не меньше 10, но не
    //превосходит 100, каждая из следующих N строк имеет следующий формат:
    //<Фамилия> <Имя> <оценки>,
    //где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
    //более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
    //пятибалльной системе. <Фамилия> и<Имя>, а также<Имя> и<оценки> разделены одним пробелом.
    //Пример входной строки:
    //Иванов Петр 4 5 3
    //Требуется написать как можно более эффективную программу, которая будет выводить на экран
    //фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
    //набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
    class Program
    {
        struct Info
        {
            public string FIO;
            public int[] Marks;
            public double AvMark;
        }

        private static int LinesCount(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                int linesCount = 0;
                while (streamReader.ReadLine() != null)
                {
                    linesCount++;
                }

                return linesCount;
            }
        }

        private static Info[] StudentBill(int count, string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                Info[] studentInfos = new Info[count];
                for (int i = 0; i < count; i++)
                {
                    string[] tempInfo = streamReader.ReadLine().Split(' ');
                    int[] tempMarks = new int[tempInfo.Length - 2];
                    studentInfos[i].FIO = tempInfo[0] + " " + tempInfo[1];
                    for (int j = 0; j < 2; j++)
                    {
                        tempMarks[j] = int.Parse(tempInfo[j + 2]);
                    }
                    studentInfos[i].Marks = tempMarks;
                }
                return studentInfos;
            }
        }

        private static double AverageMark(int[] marks)
        {
            return marks.Average();
        }
       
        static void Main(string[] args)
        {
            
            int linesCount;
            string pathToFile = @"..\\..\\data\\data.txt";
            linesCount = LinesCount(pathToFile);
            Info[] bill = StudentBill(linesCount, pathToFile);
            for (int i = 0; i < bill.Length; i++)
            {
                bill[i].AvMark = AverageMark(bill[i].Marks);
            }
            List<Info> tempInfos = bill.ToList();
            tempInfos.Sort(delegate (Info av1, Info av2)
            {
                return av1.AvMark.CompareTo(av2.AvMark);
            });

            for (int i = 0; i < tempInfos.Count; i++)
            {
                if(i >= 0 && i <= 2)
                {
                    Console.WriteLine($"{tempInfos[i].FIO} ср.балл - {tempInfos[i].AvMark:f2}");
                }else if(tempInfos[i].AvMark < tempInfos[2].AvMark)
                {
                    Console.WriteLine($"{tempInfos[i].FIO} ср.балл - {tempInfos[i].AvMark:f2}");
                }
            }
            Console.ReadKey();
        }
    }
}
