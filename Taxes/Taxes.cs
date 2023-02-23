namespace Taxes
{
    public class Taxes
    {
        private decimal annualIncome = 0;

        public void SetAnnualIncome(decimal AnnualIncome)
        {
            annualIncome = AnnualIncome;
        }

        public decimal CalculateTaxesAmount()
        {
            if (annualIncome <= 0)
            {
                throw new ArgumentException("Le revenu doit être supérieur à zéro.");
            }

            if (annualIncome <= 10777)
            {
                return 0;
            }
            else if (annualIncome <= 27478)
            {
                return Decimal.Round((annualIncome - 10777) * 0.11m, 2);
            }
            else if (annualIncome <= 78570)
            {
                return Decimal.Round((annualIncome - 27478) * 0.3m + 1881.71m, 2);
            }
            else if (annualIncome <= 168994)
            {
                return Decimal.Round((annualIncome - 78570) * 0.41m + 14668.62m, 2);
            }
            else
            {
                return Decimal.Round((annualIncome - 168994) * 0.45m + 58532.51m, 2);
            }
        }

        public decimal CalculateTaxesRate()
        {
            if (annualIncome <= 0)
            {
                throw new ArgumentException("Le revenu doit être supérieur à zéro.");
            }

            decimal taxesAmount = CalculateTaxesAmount();
            decimal rate = taxesAmount / annualIncome;

            return Decimal.Round(rate * 100, 2);
        }
    }
}