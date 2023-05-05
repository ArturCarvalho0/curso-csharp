using System;
using Course.Entities;
using ExeHeritage.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Carlos", 500.0, 500.00));

            double sum = 0.0;

            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total balance: " + sum);

            foreach (Account account in list)
            {
                account.Withdraw(10.0);
            }

            foreach(Account account in list)
            {
                Console.WriteLine("Updated balance for account " + account.Number + ": " + account.Balance);
            }
        }   
    }
}