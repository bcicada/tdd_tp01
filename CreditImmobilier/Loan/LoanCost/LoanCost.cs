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
        private readonly LoanInterest _loanInterest;

        public LoanCost(LoanAmount loanAmount, LoanTermInMonths loanTermInMonths, LoanInterest loanInterest) 
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
