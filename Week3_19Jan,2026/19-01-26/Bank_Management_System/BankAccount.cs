using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Management_System
{
    internal class BankAccount
    {
        public string HolderName;
        public int AccountNo;
        int Password;
        protected int Balance;

        public BankAccount()
        {
            Console.WriteLine("Enter account holder name: "+ HolderName);
            HolderName = Console.ReadLine();
            Console.WriteLine("Enter account number: ");
            AccountNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Balance of account: ");
            Balance = int.Parse(Console.ReadLine());
        }

        public BankAccount(string name, int accNo, int bal)
        {
            HolderName = name;
            AccountNo = accNo;
            Balance = bal;
        }
        public void depositAmt(int deposit)
        {
            Console.WriteLine("Amount to be deposited: "+ deposit);
            Balance += deposit;
            Console.WriteLine("Updated Balance after depositing "+deposit+ ": "+ Balance);
        }
        public void withdrawAmt(int withdraw)
        {
            Console.WriteLine("Amount to be withdraw: "+ withdraw);
            Balance -= withdraw;
            Console.WriteLine("Updated Amount after withdrawing "+ withdraw+ ": "+ Balance); 
        }
        public void DisplaySummary()
        {
            Console.WriteLine("---Account Summary---");
            Console.WriteLine("Account Holder Name: " + HolderName);
            Console.WriteLine("Account Number     : "+ AccountNo);
            Console.WriteLine("Balance            : "+ Balance);

        }
    }
    class SavingsAccount : BankAccount
    {
        public int rate;
        public SavingsAccount() {
            Console.WriteLine("enter the rate of interest: ");
            this.rate = int.Parse(Console.ReadLine());
        }
        public void Interest()
        {
            rate = (Balance * rate) / 100;
            Balance += rate;
            Console.WriteLine("Interest of the Saving account: "+rate);
            Console.WriteLine("Updated Balance after Interest Calculation: " + Balance);
        }
        
    }
    class CheckingAccount : BankAccount
    {
        private int transactionCount = 0;
        private int dailyTransactionLimit;
        public CheckingAccount()
        {
            Console.WriteLine("Enter daily transaction Limit: ");
            this.dailyTransactionLimit = int.Parse(Console.ReadLine());
        }

        public void Deposit1(int amount)
        {
            if( transactionCount <  dailyTransactionLimit )
            {
                Balance += amount;
                transactionCount++;
                Console.WriteLine("Amount deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Daily Transaction limit reached");
            }
        }
        public void withdraw1(int amount)
        {
            if(transactionCount < dailyTransactionLimit)
            {
                if(Balance >  amount)
                {
                    Balance -= amount;
                    transactionCount++;
                    Console.WriteLine("Amount Withdrawn: "+ amount);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance!!");
                }
            }
            else
            {
                Console.WriteLine("Daily Transaction Limit reached.");
            }
        }
        public void ShowTransactions()
        {
            Console.WriteLine("Transactions today: " + transactionCount);
        }
    }
}
