using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmobilier.Loan.LoanCost
{
    public interface ILoanCost
    {
        double CalculateMonthlyLoanCost();
        double CalculateTotalLoanCost();
    }
}
