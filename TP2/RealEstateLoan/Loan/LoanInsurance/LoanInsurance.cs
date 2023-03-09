using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.RealEstateLoan.Loan.LoanInsurance
{
    public class LoanInsurance : ILoanInsurance
    {
        private readonly LoanAmount _loanAmount;
        private readonly LoanTermInMonths _loanTermInMonths;
        private double LoanInsuranceInterest;

        public LoanInsurance(LoanAmount loanAmount, LoanTermInMonths loanTermInMonths, bool isSporty, bool isSmoker, bool asHeartCondition, bool isComputerEngineer, bool isFighterPilot)
        {
            _loanAmount = loanAmount;
            _loanTermInMonths = loanTermInMonths;
            LoanInsuranceInterest = 0.003;
            CalculateLoanInsuranceInterest(isSporty, isSmoker, asHeartCondition, isComputerEngineer, isFighterPilot);
        }

        private void CalculateLoanInsuranceInterest(bool isSporty, bool isSmoker, bool asHeartCondition, bool isComputerEngineer, bool isFighterPilot)
        {
            if (isSporty) LoanInsuranceInterest -= 0.0005;
            if (isSmoker) LoanInsuranceInterest += 0.0015;
            if (asHeartCondition) LoanInsuranceInterest += 0.003;
            if (isComputerEngineer) LoanInsuranceInterest -= 0.0005;
            if (isFighterPilot) LoanInsuranceInterest += 0.0015;
        }

        public double CalculateMonthlyLoanInsuranceCost()
        {
            return Math.Round((double)_loanAmount * LoanInsuranceInterest / 12, 2);
        }

        public double CalculateTotalLoanInsuranceCost()
        {
            return Math.Round(CalculateMonthlyLoanInsuranceCost() * (double)_loanTermInMonths, 2);
        }
    }
}
