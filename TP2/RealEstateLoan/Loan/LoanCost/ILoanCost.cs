using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.RealEstateLoan.Loan.LoanCost
{
    public interface ILoanCost
    {
        double CalculateMonthlyLoanCost();
        double CalculateMonthlyLoanCostWithoutInterest(int months);
        double CalculateTotalLoanCost();
        double CalculateTotalLoanInterestCost();
    }
}
