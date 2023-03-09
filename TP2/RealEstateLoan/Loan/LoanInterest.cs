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
            _interest = interest;
        }

        public double GetInterest()
        { return _interest; }

        public static explicit operator double(LoanInterest v)
        {
            throw new NotImplementedException();
        }
    }
}
