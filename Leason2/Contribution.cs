using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leason2
{
    public class Contribution : BankAccount
    {
        private decimal Balance { get; set; }

        public BankType TypeAccountNumber { get; } = (BankType)3;

        public Contribution(int balanse)
        {
            Balance = balanse;
        }

    }
}