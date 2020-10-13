using System;
using System.Collections.Generic;
using System.IO;

namespace Less6Ex3
{
    //Переделать программу «Пример использования коллекций» для решения следующих задач:
    //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
    //в) отсортировать список по возрасту студента;
    //г) * отсортировать список по курсу и возрасту студента;
    //д) разработать единый метод подсчета количества студентов по различным параметрам
    //выбора с помощью делегата и методов предикатов.
    //*Достаточно решить 2 задачи.Старайтесь разбивать программы на подпрограммы.Переписывайте в начало программы условие и свою фамилию. Все программы сделайте в одном решении.

    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department,  int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }


    class Program
    {
        static int AgeCompare(Student st1, Student st2)
        {
            if (st1.age > st2.age) return 1;
            if (st1.age < st2.age) return -1;
            return 0;
        }

        static int CourseAndAgeCompare(Student st1, Student st2)
        {
            if (st1.age > st2.age) return 1;
            if (st1.age < st2.age) return -1;
            if (st1.course > st2.course) return 1;
            if (st1.course < st2.course) return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int fiveCourseCount = 0;
            int sixCourseCount = 0;
            List<Student> list = new List<Student>();
            Dictionary<int, int> frecDic = new Dictionary<int, int>();
            StreamReader sr = new StreamReader(@"..\\..\\data\\students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[6]) == 5) fiveCourseCount++;
                    else if (int.Parse(s[6]) == 6) sixCourseCount++;
                    if (int.Parse(s[5]) > 17 && int.Parse(s[5]) < 21)
                    {
                        if (frecDic.ContainsKey(int.Parse(s[6])))
                            frecDic[int.Parse(s[6])] += 1;
                        else
                            frecDic.Add(int.Parse(s[6]), 1);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(AgeCompare));
            Console.WriteLine($"Всего студентов: {list.Count}");
            Console.WriteLine($"Всего студентов обучающихся на 5 курсе: {fiveCourseCount}");
            Console.WriteLine($"Всего студентов обучающихся на 6 курсе: {sixCourseCount}");
            Console.WriteLine();
            Console.WriteLine($"Отсортированные студенты по возрасту");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");
            Console.WriteLine();
            list.Sort(new Comparison<Student>(CourseAndAgeCompare));
            Console.WriteLine($"Отсортированные студенты по курсу и возрасту");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age} {v.course}");
            Console.WriteLine();
            Console.WriteLine($"студенты в возрасте от 18 до 20 лет");
            foreach (KeyValuePair<int, int> keyValuePair in frecDic) Console.WriteLine($"На {keyValuePair.Key} курсе обучаются {keyValuePair.Value} студентов");
            Console.ReadKey();

        }
    }
}
