using System;
using static Exercise6.Program;

namespace Less2Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 

            // выполнил - Noskov Konstantin
            //
            //задача:
            //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
            //программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.

            #endregion

            #region Declaring variables

            int tryCount = 0;
            string uName;
            string uPass;
            string textOutput;
            string header = "Форма авторизации пользователя";
            ConsoleColor dfltForeground = Console.ForegroundColor;

            #endregion
            
            do
            {
                Console.ForegroundColor = dfltForeground;
                PrintMsg(header, (Console.WindowWidth - header.Length) / 2, 0);
                Console.WriteLine();
                Console.Write("Имя пользователя: ");
                uName = Console.ReadLine();
                Console.Write("Пароль: ");
                uPass = Console.ReadLine();
                if (CheckAuthorization(uName, uPass))
                {
                    textOutput = $"Добро пожаловать {uName}";
                    Console.Clear();
                    PrintMsg(textOutput, (Console.WindowWidth - textOutput.Length) / 2, Console.WindowHeight / 2, ConsoleColor.Green);
                    break;
                }
                else
                {
                    textOutput = $"Введены неверные имя пользователя или пароль";
                    Console.Clear();
                    PrintMsg(textOutput, ((Console.WindowWidth - textOutput.Length) / 2), Console.WindowHeight / 2, ConsoleColor.Red);
                    Pause();
                    Console.Clear();
                    tryCount++;
                }

            } while (tryCount < 3);
            Pause();
        }

        private static bool CheckAuthorization(string login, string password)
        {
            string userName = "root";
            string userPassword = "GeekBrains";
            if (String.Compare(login, userName) == 0 && String.Compare(password, userPassword) == 0)
            {
                return true;
            }

            return false;
        }
    }
}
