using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class Deposit 
    {
        public static void GetDeposit(List<AccountInfo> accounts)
        {
            Console.Write("Enter account number: ");
            Int32.TryParse(Console.ReadLine(), out int searchAccountNumber);

            Console.Write("How much would you like to deposit: ");
            Double.TryParse(Console.ReadLine(), out double amount);

            foreach (AccountInfo account in accounts)
            {
                if (account.AccountNbr == searchAccountNumber)
                {
                    if (amount < 0)
                    {
                        Console.WriteLine("You can't deposit a negative number");
                    }
                    else
                    {
                        Console.WriteLine("Your deposit is complete");
                        account.Balance += amount;
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
