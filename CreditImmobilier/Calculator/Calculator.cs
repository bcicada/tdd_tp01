using CreditImmobilier.Loan;
using CreditImmobilier.Loan.LoanCost;
using CreditImmobilier.Loan.LoanInsurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmobilier.Calculator
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
