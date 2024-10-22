namespace OOPBankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountInfo account1 = new AccountInfo(111111, "John Smith", 2.5, 10000, -1000);

            List<AccountInfo> accounts = new List<AccountInfo>();

            accounts.Add(account1);

            bool exit = true;

            Console.WriteLine("Welcome to the Bank!");

            do
            {
                Console.WriteLine("1. Make a deposit\n2. Make a withdrawl\n3. Show balance\n4. Show all accounts balance\n5. Add new account\n6. Exit Bank");
                Int32.TryParse(Console.ReadLine(), out int menuChioce);

                if (menuChioce == 1)
                {
                    Deposit.GetDeposit(accounts);
                    EndMenu();
                }
                else if (menuChioce == 2)
                {
                    Withdraw.GetWithdraw(accounts);
                    EndMenu();
                }
                else if (menuChioce == 3)
                {
                    Console.Write("Enter account number: ");
                    Int32.TryParse(Console.ReadLine(), out int searchAccountNumber);

                    foreach (AccountInfo account in accounts)
                    {
                        if (account.AccountNbr == searchAccountNumber)
                        {
                            Console.WriteLine($"Your current balance is: {account.Balance}");
                        }
                    }
                    EndMenu();
                }
                else if (menuChioce == 4)
                {
                    Console.WriteLine("All accounts balance");

                    foreach (AccountInfo account in accounts)
                    {
                        Console.WriteLine($"Account number {account.AccountNbr} has balance {account.Balance}");
                    }
                    EndMenu();
                }
                else if (menuChioce == 5)
                {
                    accounts.Add(AddAccount.GetAddAccount(accounts));
                    EndMenu();
                }
                else if (menuChioce == 6)
                {
                    exit = false;
                }
            }
            while (exit);
        }

        public static void EndMenu()
        {
            Console.WriteLine("Press 'enter' to go back to main menu");
            Console.ReadLine();
        }
    }
}
