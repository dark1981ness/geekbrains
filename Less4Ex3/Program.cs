using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less4Ex3
{
    #region Task

    // выполнил - Noskov Konstantin
    //
    //Решить задачу с логинами из предыдущего урока,
    //только логины и пароли считать из файла в массив.
    //Создайте структуру Account, содержащую Login и Password.

    #endregion

    struct Account
    {
        public string uName;
        public string uPass;

        /// <summary>
        /// метод загрузки параметров авторизации из файла
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadFromFile(string filePath)
        {
            string[] temp = File.ReadAllLines(filePath);
            uName = temp[0].Split(':')[1];
            uPass = temp[1].Split(':')[1];
        }

        /// <summary>
        /// метод проверки пары "имя пользователя/пароль"
        /// </summary>
        /// <returns></returns>
        public bool CheckAuthorization()
        {
            string userName = "root";
            string userPassword = "GeekBrains";
            if (String.Compare(uName, userName) == 0 && String.Compare(uPass, userPassword) == 0)
            {
                return true;
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Account account;
            account.uName = string.Empty;
            account.uPass = string.Empty;
            account.ReadFromFile(@"..\\..\\auth\auth.txt");
            Console.WriteLine(account.CheckAuthorization());
            Console.ReadKey();
        }
    }
}
