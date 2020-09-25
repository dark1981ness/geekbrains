using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 
            // выполнил - Noskov Konstantin
            //
            //задача:
            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            #endregion

            #region Declaring variables

            string name;
            string surName;
            byte age;
            byte height;
            ushort weight;

            #endregion

            Console.WriteLine($"Добро пожаловать в программу анкетирования");
            Console.WriteLine($"Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
            Console.Write($"Введите ваше имя: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write($"Введите вашу фамилию: ");
            surName = Convert.ToString(Console.ReadLine());
            Console.Write($"Введите ваш возраст: ");
            age = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите ваш рост: ");
            height = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите ваш вес: ");
            weight = Convert.ToUInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Ваши анкетные данные");

            #region concat output

            Console.WriteLine("Склеивание:");
            Console.WriteLine("Имя: " + name + "\nФамилия: " + surName + "\nВозраст: " + age + "\nРост: " + height + "\nВес: " + weight + "\n");

            #endregion

            #region format output

            Console.WriteLine("Форматированный вывод");
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nВозраст: {2:d}\nРост: {3:d}\nВес: {4:d}\n", name, surName, age, height, weight);

            #endregion

            #region interpolation output

            Console.WriteLine("Интерполяция строк");
            Console.WriteLine($"Имя: {name}\nФамилия: {surName}\nВозраст: {age}\nРост: {height}\nВес: {weight}\n");

            #endregion

            Console.ReadLine();
        }
    }
}
