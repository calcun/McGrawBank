using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MccrawProject3
{
    public class SavingsAccount : Account
    {
        public double MinimumBalance { get; private set; }

        public SavingsAccount(int id, string name, double balance, double intRate, double minimumBalance)
            : base(id, name, balance, intRate)
        {
            this.MinimumBalance = minimumBalance;
        }

        protected override double CalculateMonthlyInterest()
        {
            if (this.Balance >= this.MinimumBalance)
            {
                return base.CalculateMonthlyInterest();
            }
            return 0;
        }

    }
}
