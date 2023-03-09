using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.RealEstateLoan.Loan.LoanInsurance
{
    public interface ILoanInsurance
    {
        double CalculateMonthlyLoanInsuranceCost();
        double CalculateTotalLoanInsuranceCost();
    }
}
