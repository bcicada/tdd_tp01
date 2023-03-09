using TP2.RealEstateLoan.Loan;
using TP2.RealEstateLoan.Loan.LoanInsurance;

namespace RealEstateLoanTest
{
    public class RealEstateLoanTest
    {
        [Theory]
        [InlineData(100000.00, 240, false, false, false, false, false, 25)]
        public void LoanInsurance_ReturnsCorrectMonthlyLoanInsuranceCost(LoanAmount loanAmount, LoanTermInMonths loanTermInMonths, bool isSporty, bool isSmoker, bool hasHeartCondition, bool isComputerEngineer, bool isFighterPilot, double expected)
        {
            // Arrange
            var monthlyLoanInsuranceCost = new LoanInsurance(loanAmount, loanTermInMonths, isSporty, isSmoker, hasHeartCondition, isComputerEngineer, isFighterPilot);

            // Act & Assert
            Assert.Equal(expected, monthlyLoanInsuranceCost.CalculateMonthlyLoanInsuranceCost());

        }
    }
}