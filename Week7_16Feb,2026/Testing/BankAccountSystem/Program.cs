namespace BankAccountSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create account with initial balance
            BankAccount account = new BankAccount(1000m);

            Console.WriteLine("Initial Balance: " + account.Balance);

            // Deposit money
            account.Deposit(500m);
            Console.WriteLine("After Deposit: " + account.Balance);

            // Withdraw money
            account.Withdraw(300m);
            Console.WriteLine("After Withdrawal: " + account.Balance);

            // Attempt to withdraw more than balance
            try
            {
                account.Withdraw(2000m);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Final Balance: " + account.Balance);
        }
    }
}