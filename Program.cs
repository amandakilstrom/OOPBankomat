namespace OOPBankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountInfo account1 = new AccountInfo(1, "John Smith", 2.5, 10000, -1000);
            AccountInfo account2 = new AccountInfo(2, "Jane Smith", 2.0, 50000, -1000);
            AccountInfo account3 = new AccountInfo(3, "Elma Smith", 2.3, 30000, -1000);

            List<AccountInfo> accounts = new List<AccountInfo>();

            accounts.Add(account1);
            accounts.Add(account2);
            accounts.Add(account3);

            bool exit = true;

            Console.WriteLine("Welcome to the Bank!");

            do
            {
                Console.WriteLine("1. Make a deposit" +
                    "\n2. Make a withdrawl" +
                    "\n3. Show balance" +
                    "\n4. Show all accounts balance" +
                    "\n5. Add new account" +
                    "\n6. Remove one account" +
                    "\n7. Sort accounts" +
                    "\n8. Pay out interest to all accounts" +
                    "\n9. Exit Bank");
                Int32.TryParse(Console.ReadLine(), out int menuChioce);

                Console.Clear();

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
                    // Kallar på GetRemoveAccount metoden för att ta bort ett konto
                    RemoveAccount.GetRemoveAccount(accounts);
                    EndMenu();
                }
                else if (menuChioce == 7)
                {
                    // Kallar på GetSort metoden och skickar med listan
                    SortAccounts.GetSort(accounts);
                    // Skriver ut den sorterade listan åt användaren
                    foreach (AccountInfo account in accounts)
                    {
                        Console.WriteLine($"Account Number: {account.AccountNbr} " +
                            $" Account name: {account.AccountName} " +
                            $" Interest rate: {account.InterestRate} " +
                            $" Balance: {account.Balance} " +
                            $" Max credit: {account.MaxCredit}");
                    }
                    EndMenu();
                }
                else if (menuChioce == 8)
                {
                    // Kallar på en funktion som har en lista som inparameter
                    PayOutInterest.GetPayOutInterest(accounts);
                    EndMenu();
                }
                else if (menuChioce == 9)
                {
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1-9");
                    EndMenu();
                }
            }
            while (exit);
        }

        public static void EndMenu()
        {
            Console.WriteLine("Press 'enter' to go back to the main menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
