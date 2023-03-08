using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmobilier
{
    public class LoanInsurance : ILoanInsurance
    {
        private readonly LoanAmount _loanAmount;
        private readonly LoanTermInMonths _loanTermInMonths;
        private double _loanInsuranceInterest;

        public LoanInsurance(LoanAmount loanAmount, LoanTermInMonths loanTermInMonths, bool isSporty, bool isSmoker, bool asHeartCondition, bool isComputerEngineer, bool isFighterPilot) 
        {
            _loanAmount = loanAmount;
            _loanTermInMonths = loanTermInMonths;
            _loanInsuranceInterest = 0.3;
            CalculateLoanInsuranceInterest(isSporty, isSmoker, asHeartCondition, isComputerEngineer, isFighterPilot);
        }

        private void CalculateLoanInsuranceInterest(bool isSporty, bool isSmoker, bool asHeartCondition, bool isComputerEngineer, bool isFighterPilot)
        {
            if (isSporty) _loanInsuranceInterest -= 0.05;
            if (isSmoker) _loanInsuranceInterest += 0.15;
            if (asHeartCondition) _loanInsuranceInterest += 0.3;
            if (isComputerEngineer) _loanInsuranceInterest -= 0.05;
            if (isFighterPilot) _loanInsuranceInterest += 0.15;
        }

        public double CalculateMonthlyLoanInsuranceCost()
        {
            return 0;
        }

        public double CalculateTotalLoanInsuranceCost()
        {
            return 0;
        }
    }
}
