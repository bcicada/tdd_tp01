using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.RealEstateLoan.Loan
{
    public class LoanAmount
    {
        private double _amount { get; }

        public LoanAmount(double amount)
        {
            _amount = amount < 50000 ? throw new ArgumentOutOfRangeException(nameof(amount), "The amount borrowed must be greater than 50000.") : amount;
        }

        public static explicit operator double(LoanAmount loanAmount)
        {
            return loanAmount._amount;
        }

        public static explicit operator LoanAmount(double amount)
        {
            return new LoanAmount(amount);
        }
    }
}
