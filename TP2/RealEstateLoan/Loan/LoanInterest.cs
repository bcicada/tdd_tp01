using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.RealEstateLoan.Loan
{
    public class LoanInterest
    {
        private double _interest { get; }

        public LoanInterest(double interest)
        {
            _interest = interest / 100;
        }

        public static explicit operator double(LoanInterest loanInterest)
        {
            return loanInterest._interest;
        }

        public static implicit operator LoanInterest(double interest)
        {
            return new LoanInterest(interest);
        }
    }
}
