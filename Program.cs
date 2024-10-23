namespace OOPBankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Konton som finns i programmet från början
            AccountInfo account1 = new AccountInfo(1, "John Smith", 2.5, 10000, -1000);
            AccountInfo account2 = new AccountInfo(2, "Jane Smith", 2.0, 50000, -1000);
            AccountInfo account3 = new AccountInfo(3, "Elma Smith", 2.3, 30000, -1000);

            // En lista med olika konton
            List<AccountInfo> accounts = new List<AccountInfo>();

            // Lägger in kontonen som finns i programmet in i listan
            accounts.Add(account1);
            accounts.Add(account2);
            accounts.Add(account3);

            bool exit = true;

            // Hälsar användaren välkommen till banken
            Console.WriteLine("Welcome to the Bank!");

            // En do while loop som kommer att köras så långe exit är true
            do
            {
                // Huvudmenyn
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

                // Rensar all text i konsol fönstret
                Console.Clear();

                if (menuChioce == 1)
                {
                    // Kallar på en metod sör att sätta in pengar
                    Deposit.GetDeposit(accounts);
                    // Kallar på en metod som talar om för användaren hur man kommer till huvudmenyn
                    EndMenu();
                }
                else if (menuChioce == 2)
                {
                    // Kallar på en metod för att ta ut pengar
                    Withdraw.GetWithdraw(accounts);
                    EndMenu();
                }
                else if (menuChioce == 3)
                {
                    // Kallar på en metod som isar ett kontos saldo
                    ShowAccountBalance.GetShowBalance(accounts);
                    EndMenu();
                }
                else if (menuChioce == 4)
                {
                    // Ger ett meddelande till användaren som säger att det är alla konton i listan
                    Console.WriteLine("All accounts balance");

                    // en foreach loop som går igenom alla konton
                    foreach (AccountInfo account in accounts)
                    {
                        // Skriver ut vilket kontonummer som har vilket saldo
                        Console.WriteLine($"Account number {account.AccountNbr} has balance {account.Balance}");
                    }
                    EndMenu();
                }
                else if (menuChioce == 5)
                {
                    // Kallar på en funktion för att lägga till ett konto i listan
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
                    // Avslutar programmet
                    exit = false;
                }
                else
                {
                    // Ger ett felmeddelande till användaren om inget korrekt menyval har gjorts
                    Console.WriteLine("Please enter a number between 1-9");
                    EndMenu();
                }
            }
            while (exit);
        }

        // En metod som ger användaren ett meddelande och väntar på användarens input
        // för att sen rensa konsol fönstret
        public static void EndMenu()
        {
            Console.WriteLine("Press 'enter' to go back to the main menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
