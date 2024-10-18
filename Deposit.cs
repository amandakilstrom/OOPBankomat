using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class Deposit 
    {
        public static Double GetDeposit(Double amount, Double balance)
        {
            if (amount < 0)
            {
                Console.WriteLine("You can't deposit a negative number");
            }
            else
            {
                Console.WriteLine("Your deposit is complete");
                balance += amount;
            }

            return balance;
        }
    }
}
