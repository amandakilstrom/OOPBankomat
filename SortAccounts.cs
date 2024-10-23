using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class SortAccounts
    {
        // En statisk void metod som tar in listan med objekt
        public static void GetSort(List<AccountInfo> accounts)
        {
            // Frågar användaren hur listan ska sorteras
            Console.WriteLine("How do you wan't to sort the accounts?\n1. By balance\n2. By interest rate");
            Console.Write("Choice: ");
            // Sparar användarens svar i int choice
            Int32.TryParse(Console.ReadLine(), out int choice);

            if (choice == 1)
            {
                // Frågar användaren vilken ordning listan ska sorteras
                Console.WriteLine("In which order do you want to sort the accounts?\n1. Descending\n2. Ascending");
                Int32.TryParse(Console.ReadLine(), out choice);

                if (choice == 1)
                {
                    // Sorterar accounts genom att jämföra två Balance strukturer med varandra
                    accounts.Sort((x, y) => x.Balance.CompareTo(y.Balance));
                    // Metoden reverse används för att ändra ordning i listan då sort metoden
                    // gör så att listan sorteras från lägst till högst
                    accounts.Reverse();
                }
                else if (choice == 2)
                {
                    accounts.Sort((x, y) => x.Balance.CompareTo(y.Balance));
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("In which order do you want to sort the accounts?\n1. Descending\n2. Ascending");
                Int32.TryParse(Console.ReadLine(), out choice);

                if (choice == 1)
                {
                    // Sorterar accounts genom att jämföra två InterestRate strukturer med varandra
                    accounts.Sort((x, y) => x.InterestRate.CompareTo(y.InterestRate));
                    accounts.Reverse();
                }
                else if (choice == 2)
                {
                    accounts.Sort((x, y) => x.InterestRate.CompareTo(y.InterestRate));
                }
            }
        }
    }
}
