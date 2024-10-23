using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class Withdraw 
    {
        // En statisc metod som tar emot en lista med objekt
        public static void GetWithdraw(List<AccountInfo> accounts)
        {
            // Ber användaren att skriva in ett kontonummer
            Console.Write("Enter account number: ");
            Int32.TryParse(Console.ReadLine(), out int searchAccountNumber);

            // Frågar användaren hur mycket pengar som ska tas ut
            Console.Write("How much would you like to withdraw: ");
            Double.TryParse(Console.ReadLine(), out double amount);

            // en foreach loop som går igenom alla konton
            foreach (AccountInfo account in accounts)
            {
                // Om användarens sökning stämmer överens med ett kontonummer
                if (account.AccountNbr == searchAccountNumber)
                {
                    // Om summan användaren vill ta ut inte är mindre än max krediten
                    if (account.Balance - amount < account.MaxCredit)
                    {
                        // Ger ett meddelande till användaren
                        Console.WriteLine("The maximum credit has been reached");
                        // Återgår till main metoden
                        return;
                    }
                    else
                    {
                        // Talar om för användaren att transaktionen lyckades
                        Console.WriteLine("Your transaction is complete");
                        // Tar summan som användaren skrev från saldot
                        account.Balance -= amount;
                        return;
                    }
                }
            }

            // Ger ett meddelande till användaren om kontot inte hittades
            Console.WriteLine($"Account {searchAccountNumber} was not found");
        }
    }
}
