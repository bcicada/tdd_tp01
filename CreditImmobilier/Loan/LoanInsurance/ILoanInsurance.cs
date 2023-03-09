using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmobilier.Loan.LoanInsurance
{
    public interface ILoanInsurance
    {
        double CalculateMonthlyLoanInsuranceCost();
        double CalculateTotalLoanInsuranceCost();
    }
}
