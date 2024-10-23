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
        // En statisc metod som tar emot en lista med objekt
        public static void GetDeposit(List<AccountInfo> accounts)
        {
            // Ber användaren att skriva in ett kontonummer
            Console.Write("Enter account number: ");
            Int32.TryParse(Console.ReadLine(), out int searchAccountNumber);

            // Frågar användaren hur mycket som ska sätts in på kontot
            Console.Write("How much would you like to deposit: ");
            Double.TryParse(Console.ReadLine(), out double amount);

            // en foreach loop som går igenom alla konton
            foreach (AccountInfo account in accounts)
            {
                // Om användarens sökning stämmer överens med ett kontonummer
                if (account.AccountNbr == searchAccountNumber)
                {
                    // Om summan användaren vill ta ut är mindre än 0
                    if (amount < 0)
                    {
                        // Ger ett meddelande till användaren
                        Console.WriteLine("You can't deposit a negative number");
                        // Återgår till main metoden
                        return;
                    }
                    else
                    {
                        // Talar om för användaren att transaktionen lyckades
                        Console.WriteLine("Your deposit is complete");
                        // Tar summan användaren skrev och till på saldo
                        account.Balance += amount;
                        return;
                    }
                }
            }

            // Ger ett meddelande till användaren om kontot inte hittades
            Console.WriteLine($"Account {searchAccountNumber} was not found");
        }
    }
}
