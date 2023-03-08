using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmobilier
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

        public static explicit operator double(LoanTermInMonths v)
        {
            throw new NotImplementedException();
        }
    }
}
