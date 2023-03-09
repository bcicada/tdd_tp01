using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.RealEstateLoan.Loan.LoanCost
{
    public class LoanCost : ILoanCost
    {
        private readonly LoanAmount _loanAmount;
        private readonly LoanTermInMonths _loanTermInMonths;
        private readonly LoanInterest _loanInterest;
        private double _monthlyLoanInterest;

        public LoanCost(LoanAmount loanAmount, LoanTermInMonths loanTermInMonths, LoanInterest loanInterest)
        {
            _loanAmount = loanAmount;
            _loanTermInMonths = loanTermInMonths;
            _loanInterest = loanInterest;
            _monthlyLoanInterest = (double) _loanInterest / 12;
        }

        public double CalculateMonthlyLoanCost()
        {
            return Math.Round((double)_loanAmount * _monthlyLoanInterest / (1 - Math.Pow(1 + _monthlyLoanInterest, -(double) _loanTermInMonths)), 2);
        }

        public double CalculateMonthlyLoanCostWithoutInterest(int months)
        {
            return Math.Round((double)_loanAmount * ((Math.Pow(1+_monthlyLoanInterest, months) -1) / (Math.Pow(1+_monthlyLoanInterest,(double) _loanTermInMonths) -1)), 2);
        }

        public double CalculateTotalLoanCost()
        {
            return Math.Round(CalculateMonthlyLoanCost() * (double) _loanTermInMonths, 2);
        }

        public double CalculateTotalLoanInterestCost()
        {
            return Math.Round(CalculateTotalLoanCost() - (double) _loanAmount, 2);
        }
    }
}
