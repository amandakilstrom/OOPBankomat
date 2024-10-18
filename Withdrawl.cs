using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class Withdrawl : AccountInfo
    {
        public Withdrawl(int accountNbr, String accountName, Double interestRate, Double balance, Double maxCredit) : base(accountNbr, accountName, interestRate, balance, maxCredit){ }

        public Double GetWithdrawl(Double amount)
        {
            if (Balance - amount >= MaxCredit)
            {
                Console.WriteLine("The maximum credit has been reached");
            }
            else
            {
                Console.WriteLine("Your transaction is complete");
                Balance -= amount;
            }

            return Balance;
        }
    }
}
