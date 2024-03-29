using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_17March_
{
    public class BankAccount
    {
        public string Owner { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
        }

        public void Credit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than or equal to zero.");
            }

            Balance += amount;
        }
    }
}
