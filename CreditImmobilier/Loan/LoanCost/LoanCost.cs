using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmobilier.Loan.LoanCost
{
    public class LoanCost : ILoanCost
    {
        private readonly LoanAmount _loanAmount;
        private readonly LoanTermInMonths _loanTermInMonths;
        private double _loanInterest;

        public LoanCost() 
        {

        }

        public double CalculateMonthlyLoanCost()
        {

        }

        public double CalculateTotalLoanCost()
        {

        }
    }
}
