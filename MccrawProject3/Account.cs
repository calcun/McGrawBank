using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MccrawProject3
{
    public class Account
    {
        public int AccountId { get; private set; }
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public double InterestRate { get; private set; }

        protected Account(int id, string name, double balance, double intRate)
        {
            this.AccountId = id;
            this.Name = name;
            this.Balance = balance;
            this.InterestRate = intRate;
        }

        protected void UpdateBalance(double newBalance)
        {
            this.Balance = newBalance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                UpdateBalance(this.Balance + amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool Withdrawal(double amount)
        {
            if (this.Balance >= amount)
            {
                UpdateBalance(this.Balance - amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual double CalculateMonthlyInterest()
        {
            if (this.Balance <= 0)
                return 0;

            return (this.Balance * this.InterestRate / 12.0);
        }

        public virtual double GiveMonthlyInterest()
        {
            double interest = CalculateMonthlyInterest();
            UpdateBalance(this.Balance + interest);

            return interest;
        }

    }
}
