using System;
using System.Text.RegularExpressions;

namespace Less5Ex1
{
    //Создать программу, которая будет проверять корректность ввода логина.
    //Корректным логином будет строка от 2 до 10 символов,
    //содержащая только буквы латинского алфавита или цифры,
    //при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    //б) с использованием регулярных выражений.

    struct Account
    {
        public string uName;

        /// <summary>
        /// метод проверки имени пользователя
        /// </summary>
        /// <returns></returns>
        public bool CheckAuthorization()
        {
            if (uName.Length >= 2 && uName.Length <= 10)
            {
                if (Char.IsDigit(uName[0]))
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < uName.Length; i++)
                    {
                        if ((uName[i] >= 'a' && uName[i] <= 'z') || (uName[i] >= 'A' && uName[i] <= 'Z') || char.IsDigit(uName[i]))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// метод проверки имени пользователя с использованием RegEx
        /// </summary>
        /// <returns></returns>
        public bool CheckAuthorizationRegEx()
        {
            Regex chkCred = new Regex(@"^[^0-9]{1}[A-Za-z0-9]{1,9}$");
            if (chkCred.IsMatch(uName))
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
            Console.WriteLine($"Авторизация пользователя");
            Console.Write($"Имя пользователя: ");
            account.uName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(account.CheckAuthorization());
            Console.WriteLine(account.CheckAuthorizationRegEx());
            Console.WriteLine(account.uName);
            Console.ReadLine();
        }
    }
}
