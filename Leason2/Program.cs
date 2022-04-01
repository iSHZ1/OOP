using System;

namespace Leason2
{
    class Program
    {
        public static void Main()
        {
            bool Session = true;
            int a;
            int b;
            decimal c;
            int command;

            Console.WriteLine("У Вас нет счетов, нужно создать счет");
            do
            {
                Console.Write("Введите баланс счета: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (a < 0)
                {
                    Console.WriteLine("Баланс должен быть положительным");
                }
            }
            while (a < 0);

            do
            {
                Console.WriteLine("Выберите тип счета:");
                Console.WriteLine("1 - Счет для юридического лица");
                Console.WriteLine("2- Счет физического лица");
                Console.WriteLine("3 - Вклад(Снимать деньги нельзя)");
                Console.WriteLine("4 - Накопительный счет");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (b < 0 || b > 3)
                {
                    Console.WriteLine("Тип счета должен быть от 1 до 4");
                }
            }
            while (b < 1 || b > 4);

            Console.Clear();
            // Хотел вначале как-то так сделать, но потом не смог обойти эту логику, не понял, пытался с as шаманить, не получилось
            //if (b == 3)
            //{
            //    Contribution Check = new Contribution(a);
            //}
            //else
            //{
            //    BankAccount Check = new BankAccount(a, b);
            //}


            BankAccount Check = new BankAccount(a, b);

            while (Session)
            {
                Console.WriteLine("Выберите команду в банкомате");
                Console.WriteLine("1 - Пополнение счета");
                Console.WriteLine("2- Снять деньги со счета");
                Console.WriteLine("3 - Посмотреть инфомацию по счету");
                Console.WriteLine("4 - Закончить работу");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите сумму");
                        c = Convert.ToDecimal(Console.ReadLine());
                        Check.ReplenishmentBalance(c);
                        break;
                    case 2:
                        if (b == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Со вклада снимать деньги нельзя");
                            Console.WriteLine("Нажмите любую клавишу для продолжения");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Введите сумму");
                            c = Convert.ToDecimal(Console.ReadLine());
                            Check.WithdrawMoney(c);
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        Console.Clear();
                        Check.PrintInfoBankAccount();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Удачного дня!");
                        Console.ReadKey();
                        return;

                }
            }
        }
    }
}