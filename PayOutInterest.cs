using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class PayOutInterest
    {
        // En static funktion som tar in en lista med objekt
        public static List<AccountInfo> GetPayOutInterest(List<AccountInfo> accounts)
        {
            // Går igenom hela listan med en foreach metod
            foreach (AccountInfo account in accounts)
            {
                // Tar summan och delar på 100 för att få 1 % av kontots saldo
                Double balanceOnePercent = account.Balance / 100;
                // Tar 1 % av kontots saldo och multiplicerar det med kontots räntesats för att få 
                // summan av en månads utdelning
                Double balanceInterestRate = balanceOnePercent * account.InterestRate;
                // Tar en månads utdelnig och multiplecerar det med ett år får få den totala utdelningen
                Double amuontInterest = balanceInterestRate * 12;
                // Adderar den totala utdelningen till saldot
                account.Balance += amuontInterest;
            }
            // Ger ett meddelande till användaren att utbetalningarna är genomförda
            Console.WriteLine("The payout is complete");
            // Retunerar den ändrade listan
            return accounts;
        }
    }
}
