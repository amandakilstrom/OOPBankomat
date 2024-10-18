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
                Console.WriteLine("1. Make a deposit\n2. Make a withdrawl\n3. Show balance\n4. Show all accounts balance");
                Int32.TryParse(Console.ReadLine(), out int menuChioce);

                if (menuChioce == 1)
                {
                    Console.Write("Enter account number: ");
                    Int32.TryParse(Console.ReadLine(), out int searchAccountNumber);

                    Console.Write("How much would you like to deposit: ");
                    Double.TryParse(Console.ReadLine(), out double amount);

                    foreach (AccountInfo account in accounts)
                    {
                        Console.WriteLine(account.Balance);

                        if (account.AccountNbr == searchAccountNumber)
                        {
                            Double newBalance = Deposit.GetDeposit(amount, account.Balance);
                            account.Balance = newBalance;
                        }
                    }
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
