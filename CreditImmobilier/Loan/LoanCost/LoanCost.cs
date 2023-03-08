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
            _loanAmount = loanAmount;
            _loanTermInMonths = loanTermInMonths;
            _loanInterest = loanInterest;
        }

        public double CalculateMonthlyLoanCost()
        {
            double monthlyLoanInterest = (double) _loanInterest / 12;
            return Math.Round(( ((double) _loanAmount * monthlyLoanInterest) / (1 - Math.Pow((1 + monthlyLoanInterest),- (double) _loanTermInMonths)) ),2);
        }

        public double CalculateTotalLoanCost()
        {
            return Math.Round((CalculateMonthlyLoanCost() * (double) _loanTermInMonths), 2);
        }

        public double CalculateTotalLoanInterestCost()
        {
            return Math.Round(CalculateTotalLoanCost() - (double) _loanAmount, 2);
        }
    }
}
