namespace Bank_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount amt = new SavingsAccount();
            amt.depositAmt(8000);
            Console.WriteLine();
            amt.withdrawAmt(7000);
            Console.WriteLine();
            amt.DisplaySummary();
            Console.WriteLine();
            amt.Interest();
            Console.WriteLine();


            CheckingAccount ca = new CheckingAccount();
            ca.Deposit1(8000);
            Console.WriteLine();
            ca.withdraw1(6000);
            Console.WriteLine();
            ca.DisplaySummary();
            Console.WriteLine();
            ca.ShowTransactions();
        }
    }
}
