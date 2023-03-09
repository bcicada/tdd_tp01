using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.RealEstateLoan.Loan
{
    public class LoanTermInMonths
    {
        private int _loanTermInMonths { get; }

        public LoanTermInMonths(int loanTermInMonths)
        {
            if (loanTermInMonths < 108)
                throw new ArgumentOutOfRangeException(nameof(loanTermInMonths), "The number of monthly payments must be greater than 108 months.");
            else if (loanTermInMonths > 300)
                throw new ArgumentOutOfRangeException(nameof(loanTermInMonths), "The number of monthly payments must be less than 300 months.");

            _loanTermInMonths = loanTermInMonths;
        }

        public static explicit operator double(LoanTermInMonths loanTermInMonths)
        {
            return loanTermInMonths._loanTermInMonths;
        }

        public static implicit operator LoanTermInMonths(int loanTermInMonths)
        {
            return new LoanTermInMonths(loanTermInMonths);
        }
    }
}
