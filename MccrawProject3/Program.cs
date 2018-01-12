using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MccrawProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checking = new CheckingAccount(1, "Checking", 1000, 0.02, 2500);

            checking.Withdrawal(2000);
            Console.WriteLine("Overdrawn Checking: {0:C}", checking.Balance);

            double interest = checking.GiveMonthlyInterest();
            Console.WriteLine("Overdrawn interest: {0:C}", interest);

            checking.Deposit(3000);
            Console.WriteLine("Good Checking: {0:C}", checking.Balance);

            interest = checking.GiveMonthlyInterest();
            Console.WriteLine("Good interest: {0:C}", interest);


            SavingsAccount savings = new SavingsAccount(2, "Savings", 1000, 0.03, 1500);

            interest = savings.GiveMonthlyInterest();
            Console.WriteLine("Under funded savings interest: {0:C}", interest);

            savings.Deposit(2000);
            interest = savings.GiveMonthlyInterest();
            Console.WriteLine("Fully funded savings interest: {0:C}", interest);



        }
    }
}
