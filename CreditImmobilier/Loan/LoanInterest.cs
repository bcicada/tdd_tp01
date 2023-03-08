using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmobilier.Loan
{
    public class LoanInterest
    {
        private double _interest { get; }

        public LoanInterest(double interest) 
        {
            _interest = interest;
        }

        public static explicit operator double(LoanInterest v)
        {
            throw new NotImplementedException();
        }
    }
}
