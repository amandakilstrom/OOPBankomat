using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class AddAccount
    {
        // En statisk funktion som tar in en lista
        public static AccountInfo GetAddAccount(List<AccountInfo> listAccounts)
        {
            // Användaren får ange ett nytt kontonumer
            Console.Write("Enter new account number: ");
            Int32.TryParse(Console.ReadLine(), out int accountNbr);

            // Användaren får skriva in ett namn på kontot
            Console.Write("What is the account name? ");
            String? name = Console.ReadLine();

            // Om kontot är null eller en tom string
            if (name is null || name == "")
            {
                // Namn blir Unknown
                name = "Unknown";
            }
            
            // Hur mycket ränta har kontot
            Console.Write("What is the starting interest rate? ");
            Double.TryParse(Console.ReadLine(), out Double interestRate);

            // Vilket saldo börjar kontot med
            Console.Write("What is the starting balance? ");
            Double.TryParse(Console.ReadLine(), out Double balance);

            // Hur mycket är max kredtien
            Console.Write("What is the max credit? ");
            Double.TryParse(Console.ReadLine(), out Double maxCredit);

            // Lägger in alla parametrar som användaren har angivet till ett objekt
            AccountInfo newAccount = new(accountNbr, name, interestRate, balance, maxCredit);

            // Retunerar ett nytt konto
            return newAccount;
        }
    }
}
