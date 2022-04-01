using System;
using System.Collections.Generic;
using System.IO;

namespace Leason2 
{ 
    class Program
    {
        public static void Main()
        {
            bool Session = true;
            int BalanceCheck;
            int AccountNumberCheck;
            decimal UserMoney;
            int command;


            BankAccount Check = CreateCheck();
            List<BankAccount> list = new List<BankAccount>();
            list.Add(Check);


            while (Session)
            {
                Console.WriteLine("Выберите команду в банкомате");
                Console.WriteLine("1 - Пополнение счета");
                Console.WriteLine("2- Снять деньги со счета");
                Console.WriteLine("3 - Посмотреть инфомацию по счетам");
                Console.WriteLine("4 - Закончить работу");
                Console.WriteLine("5 - Создать дополнительный счет");
                Console.WriteLine("6 - Выбрать другой счет");
                Console.WriteLine("7 - Посмотреть информацию по счету");
                Console.WriteLine("8 - Перевод с одного счета на другой");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите сумму");
                        UserMoney = Convert.ToDecimal(Console.ReadLine());
                        Check.ReplenishmentBalance(UserMoney);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите сумму");
                        UserMoney = Convert.ToDecimal(Console.ReadLine());
                        Check.WithdrawMoney(UserMoney);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Clear();
                        for (int i = 0; i < list.Count; i++)
                        {
                            list[i].PrintInfoBankAccount();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Удачного дня!");
                        Console.ReadKey();
                        Session = false;
                        break;
                    case 5:
                        Console.Clear();
                        list.Add(CreateCheck());
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Введите номер счета, чтобы выбрать другой счет для работы");
                        command = Convert.ToInt32(Console.ReadLine());
                        foreach (BankAccount n in list)
                        {
                            if (n.AccountNumberCheck(command))
                            {
                                Check = n;
                            }
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Check.PrintInfoBankAccount();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Введите сумму, на которую хотите пополнить счет");
                        UserMoney = Convert.ToDecimal(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("Деньги перейдут на выбранный счет, напишите номер счета, с которого хотите пополнить этот счет");
                        command = Convert.ToInt32(Console.ReadLine());
                        foreach (BankAccount n in list)
                        {
                            if (n.AccountNumberCheck(command))
                            {
                                Check.ReplenishmentBalance(n.TransitMoney(n, UserMoney));
                            }
                        }
                        break;

                }
                Console.Clear();
            }


            //Второе задание
            Console.Clear();
            Console.WriteLine("Введите слово для задания");
            string word = Console.ReadLine();
            word = ReverseOrder(word);
            Console.WriteLine(word);




            //Третье задание
            StreamReader sr = new StreamReader("task3.txt");
            StreamWriter sw = new StreamWriter("task31.txt");

            string result = "";
            bool FindSymbol = false;

            string line;

            do
            {
                line = sr.ReadLine();
                if (line == null)
                    continue;
                for (int i = 0; i < line.ToCharArray().Length; i++)
                {
                    if (line.ToCharArray()[i] == '&')
                    {
                        FindSymbol = true;
                        i += 2;
                    }
                    if (FindSymbol)
                    {
                        result += line.ToCharArray()[i];
                    }
                }
                sw.WriteLine(result);
                result = "";
                FindSymbol = false;

            } while (line != null);

            sr.Close();
            sw.Close();
            Console.ReadLine();
        }
        public static string ReverseOrder(string word)
        {
            string result = "";
            char[] array = word.ToCharArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += array[i];
            }

            return result;
        }

        public static BankAccount CreateCheck()
        {
            int BalanceCheck;
            int AccountNumberCheck;
            string NameCheck;

            Console.WriteLine("Укажите имя счета");
            NameCheck = Console.ReadLine();
            if (NameCheck == null)
                NameCheck = "Без имени";

            do
            {
                Console.Write("Введите баланс счета: ");
                BalanceCheck = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (BalanceCheck < 0)
                {
                    Console.WriteLine("Баланс должен быть положительным");
                }
            }
            while (BalanceCheck < 0);

            do
            {
                Console.WriteLine("Выберите тип счета:");
                Console.WriteLine("1 - Счет для юридического лица");
                Console.WriteLine("2- Счет физического лица");
                Console.WriteLine("3 - Вклад");
                Console.WriteLine("4 - Накопительный счет");
                AccountNumberCheck = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (AccountNumberCheck < 0 || AccountNumberCheck > 3)
                {
                    Console.WriteLine("Тип счета должен быть от 1 до 4");
                }
            }
            while (AccountNumberCheck < 1 || AccountNumberCheck > 4);

            return new BankAccount(NameCheck, BalanceCheck, AccountNumberCheck);
        }
    }
       
}
