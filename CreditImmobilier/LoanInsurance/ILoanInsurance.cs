using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmobilier.LoanInsurance.LoanInsurance
{
    public interface ILoanInsurance
    {
        double CalculateMonthlyLoanInsuranceCost();
        double CalculateTotalLoanInsuranceCost();
    }
}
