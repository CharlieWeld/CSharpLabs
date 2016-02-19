using System;

namespace Accounts
{
    public class BankAccount
    {
        private static int noAccounts = 0; // should this be initialise here??????
        public int accountNumber;
        public double accountBalance;
        public double accountOverdraft; 
        
        // call the parameter list constructor with default values of 0
        public BankAccount():this(0,0)
        {}

        public BankAccount(double accBalance, double accOverdraft)
        {
            accountNumber = ++noAccounts; //Pre-fix incrementing
            this.accountBalance = accBalance;
            this.accountOverdraft = accOverdraft;
        }

        public void credit(double amount)
        {
            // ensure it is a postive amount being crediting
            if (amount > 0)
                accountBalance += amount;
        }

        public void debit(double amount)
        {
            double tempBalance = accountBalance - amount;

            if (tempBalance >= 0)
            {
                accountBalance = tempBalance;
            }
        }

        public void printDetails()
        {
            Console.WriteLine("This is a report for account number: " + this.accountNumber + "\n");

            Console.WriteLine("Account Balance: " + String.Format("{0:0.00}", this.accountBalance));
            Console.WriteLine("Account Overdraft: " + String.Format("{0:0.00}", this.accountOverdraft));
        }
    }

    public class TestBankAccount
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount(12000, 100);

            account1.credit(100000);
            account2.debit(200);

            account1.printDetails();
            account2.printDetails();
        }
    }
}