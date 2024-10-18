using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankomat
{
    internal class AccountInfo
    {
        public int AccountNbr { get; set; } 
        public String AccountName { get; set; }
        public Double InterestRate { get; set; } 
        public Double Balance { get; set; }
        public Double MaxCredit { get; set; }

        public AccountInfo(int accountNbr, String accountName, Double interestRate, Double balance, Double maxCredit)
        {
            AccountNbr = accountNbr;
            AccountName = accountName;
            InterestRate = interestRate;
            Balance = balance;
            MaxCredit = maxCredit;
        }
    }
}
