using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class ShowAccountBalance
    {
        public static void GetShowBalance(List<AccountInfo> accounts)
        {
            // Ber användaren att skriva in ett kontonummer
            Console.Write("Enter account number: ");
            Int32.TryParse(Console.ReadLine(), out int searchAccountNumber);

            // en foreach loop som går igenom alla konton
            foreach (AccountInfo account in accounts)
            {
                // Om användarens sökning stämmer överens med ett kontonummer
                if (account.AccountNbr == searchAccountNumber)
                {
                    // Skriver ut saldo åt användaren
                    Console.WriteLine($"Your current balance is: {account.Balance}");
                    // Återgår till main metoden
                    return;
                }
            }

            // Ger ett meddelande till användaren om kontot inte hittades
            Console.WriteLine($"Account {searchAccountNumber} was not found");
        }
    }
}
