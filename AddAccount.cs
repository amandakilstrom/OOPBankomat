using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class AddAccount
    {
        public static AccountInfo GetAddAccount(List<AccountInfo> listAccounts)
        {
            Console.Write("Enter new account number: ");
            Int32.TryParse(Console.ReadLine(), out int accountNbr);

            Console.Write("What is the account name? ");
            String? name = Console.ReadLine();

            if (name is null || name == "")
            {
                name = "Unknown";
            }

            Console.Write("What is the starting interest rate? ");
            Double.TryParse(Console.ReadLine(), out Double interestRate);

            Console.Write("What is the starting balance? ");
            Double.TryParse(Console.ReadLine(), out Double balance);

            Console.Write("What is the max credit? ");
            Double.TryParse(Console.ReadLine(), out Double maxCredit);

            AccountInfo newAccount = new(accountNbr, name, interestRate, balance, maxCredit);

            return newAccount;
        }
    }
}
