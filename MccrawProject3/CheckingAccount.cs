using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MccrawProject3
{
    public class CheckingAccount : Account
    {
        public double OverdraftLimit { get; private set; }

        public CheckingAccount(int id, string name, double balance, double intRate, double overdraftLimit)
            : base(id,name,balance,intRate)
        {
            this.OverdraftLimit = overdraftLimit;
        }

        // Alternate constructor that sets balance to $0.00
        public CheckingAccount(int id, string name, double intRate, double overdraftLimit)
            : base(id, name, 0, intRate)
        {
            this.OverdraftLimit = overdraftLimit;
        }

        public override bool Withdrawal(double amount)
        {
            double newBalance = this.Balance - amount;

            if (newBalance < 0)
            {
                if (Math.Abs(newBalance) <= this.OverdraftLimit)
                {
                    UpdateBalance(newBalance);
                }
                else
                {
                    return false;
                }
            }
            return base.Withdrawal(amount);
        }
    }
}
