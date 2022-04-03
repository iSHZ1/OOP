using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leason2
{
    public class BankAccount
    {
        private static int GenerateUid { get; set; } = 40800;

        private int AccountNumber { get; set; }

        private decimal Balance { get; set; }

        private BankType TypeAccountNumber { get; set; }

        private string Name { get; set; }


        public BankAccount(string name, int balance, int typeAccountNumber)
        {
            AccountNumber = CreateId();

            Name = name;
            Balance = balance;
            TypeAccountNumber = (BankType)typeAccountNumber;
        }

        public static int CreateId()
        {
            return ++GenerateUid;
        }

        public void ReplenishmentBalance(decimal money) 
        {
            Balance += money;
        }
        public void WithdrawMoney(decimal money)
        {
            if (Balance >= money)
            {
                Console.WriteLine($"Сумма {money} выдана");
                Balance -= money;
            }
            else
            {
                Console.WriteLine("Такой суммы нет у Вас на счете");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }

        public void PrintInfoBankAccount()
        {
            Console.WriteLine($"Имя счета - {Name}");
            Console.WriteLine($"Номер счета - {AccountNumber}");
            Console.WriteLine($"Баланс - {Balance}");
            Console.WriteLine($"Тип счета - {TypeAccountNumber}");
            Console.WriteLine();
        }

        public bool AccountNumberCheck(int i)
        {
            if (AccountNumber == i)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal TransitMoney(BankAccount Check, decimal Money)
        {
            if (Check.Balance >= Money)
            {
                Check.Balance = Check.Balance - Money;
                return Money;
            }
            else
            {
                return 0;
            }
        }

    }

    public enum BankType
    {
        Business = 1,
        Personal,
        Contribution,
        SavingsAccount
    }

}
