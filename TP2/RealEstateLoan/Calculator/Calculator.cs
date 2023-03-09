using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.RealEstateLoan.Loan.LoanCost;
using TP2.RealEstateLoan.Loan.LoanInsurance;

namespace TP2.RealEstateLoan.Calculator
{
    public class Calculator : ICalculator
    {
        private readonly LoanInsurance _loanInsurance;
        private readonly LoanCost _loanCost;

        public Calculator(LoanInsurance loanInsurance, LoanCost loanCost)
        {
            _loanInsurance = loanInsurance;
            _loanCost = loanCost;
        }

        public double CalculateMonthlyCost()
        {
            return Math.Round(_loanInsurance.CalculateMonthlyLoanInsuranceCost() + _loanCost.CalculateMonthlyLoanCost(), 2);
        }
    }
}
