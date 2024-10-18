using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class Withdraw 
    {
        public static Double GetWithdraw(Double amount, Double balance, Double credit)
        {
            if (balance - amount < credit)
            {
                Console.WriteLine("The maximum credit has been reached");
            }
            else
            {
                Console.WriteLine("Your transaction is complete");
                balance -= amount;
            }

            return balance;
        }
    }
}
