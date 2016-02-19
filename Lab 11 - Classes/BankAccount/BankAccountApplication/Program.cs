using System;
using Accounts;
using Reports;

class Program
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