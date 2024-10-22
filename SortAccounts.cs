using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class SortAccounts
    {
        public static void GetSort(List<AccountInfo> accounts)
        {
            Console.WriteLine("How do you wan't to sort the accounts?\n1. By balance\n2. By interest rate");
            Console.Write("Choice: ");
            Int32.TryParse(Console.ReadLine(), out int choice);

            if (choice == 1)
            {
                Console.WriteLine("In wich order do wanna sort the accounts\n1. High to low\n2. Low to high");
                Int32.TryParse(Console.ReadLine(), out choice);

                if (choice == 1)
                {
                    
                }
            }
        }
    }
}
