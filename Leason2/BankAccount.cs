using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leason2
{
    public class BankAccount
    {
        private static int AccountNumber { get; set; } = 40800;

        private decimal Balance { get; set; }

        private BankType TypeAccountNumber { get; set; }

        public BankAccount()
        {
            CreateId();
        }

        public BankAccount(int balance, int typeAccountNumber)
        {
            CreateId();
            Balance = balance;
            TypeAccountNumber = (BankType)typeAccountNumber;
        }

        public void CreateId()
        {
            AccountNumber++;
        }

        public void ReplenishmentBalance(decimal money) 
        {
            Balance += money;
        }
        public void WithdrawMoney(decimal money)
        {
            if (Balance >= money)
            {
                Console.WriteLine($"Выдана сумма {money}");
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
            Console.WriteLine($"Номер счета - {AccountNumber}");
            Console.WriteLine($"Баланс - {Balance}");
            Console.WriteLine($"Тип счета - {TypeAccountNumber}");
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
