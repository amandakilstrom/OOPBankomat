using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class RemoveAccount
    {
        // En metod för att ta bort ett konto ur en lista
        public static List<AccountInfo> GetRemoveAccount(List<AccountInfo> accounts)
        {
            // Frågar användaren vilket konto som ska tas bort
            Console.Write("Enter the account number on the account you want to remove: ");
            Int32.TryParse(Console.ReadLine(), out int searchAccountNbr);

            // Går igenom listan med en for loop
            for (int i = 0; i < accounts.Count; i++)
            {
                // Om användarens sökning stämmer överens med ett kontonummer i listan
                if (accounts[i].AccountNbr == searchAccountNbr)
                {
                    // Tar bort kontot som finns i listan
                    accounts.Remove(accounts[i]);
                    // Retunerar den nya listan
                    return accounts;
                }
            }
            // Om inte kontot finns i listan får användaren ett meddelande
            Console.WriteLine($"Account {searchAccountNbr} was not found");
            // Retunerar listan
            return accounts;
        }
    }
}
