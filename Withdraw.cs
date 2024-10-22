using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class Withdraw 
    {
        public static void GetWithdraw(List<AccountInfo> accounts)
        {
            Console.Write("Enter account number: ");
            Int32.TryParse(Console.ReadLine(), out int searchAccountNumber);

            Console.Write("How much would you like to withdraw: ");
            Double.TryParse(Console.ReadLine(), out double amount);

            foreach (AccountInfo account in accounts)
            {
                if (account.AccountNbr == searchAccountNumber)
                {
                    if (account.Balance - amount < account.MaxCredit)
                    {
                        Console.WriteLine("The maximum credit has been reached");
                    }
                    else
                    {
                        Console.WriteLine("Your transaction is complete");
                        account.Balance -= amount;
                    }
                }
                else
                {
                    Console.WriteLine($"Account {searchAccountNumber} was not found");
                }
            }
        }
    }
}
