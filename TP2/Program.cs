using System;
using TP2.RealEstateLoan.Calculator;
using TP2.RealEstateLoan.Loan;
using TP2.RealEstateLoan.Loan.LoanCost;
using TP2.RealEstateLoan.Loan.LoanInsurance;

namespace TP2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisiez le montant emprunté : ");
            LoanAmount loanAmount = (LoanAmount) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Saisiez le nombre de mensualité : ");
            LoanTermInMonths loanTermInMonths = (LoanTermInMonths) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Saisiez le taux d'intérêt propre à l'emprunt : ");
            LoanInterest loanInterest = (LoanInterest) Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("L'emprunteur est-il sportif ? (true/false) : ");
            bool isSporty = bool.Parse(Console.ReadLine());

            Console.WriteLine("L'emprunteur est-il fumeur ? (true/false) : ");
            bool isSmoker = bool.Parse(Console.ReadLine());

            Console.WriteLine("L'emprunteur dispose-t-il de troubles cardiaques ? (true/false) : ");
            bool hasHeartCondition = bool.Parse(Console.ReadLine());

            Console.WriteLine("L'emprunteur est-il ingénieur en informatique ? (true/false) : ");
            bool isComputerEngineer = bool.Parse(Console.ReadLine());

            Console.WriteLine("L'emprunteur est-il pilote de chasse ? (true/false) : ");
            bool isFighterPilot = bool.Parse(Console.ReadLine());

            LoanInsurance loanInsurance = new LoanInsurance(loanAmount, loanTermInMonths, isSporty, isSmoker, hasHeartCondition, isComputerEngineer, isFighterPilot);
            LoanCost loanCost = new LoanCost(loanAmount, loanTermInMonths, loanInterest);

            Calculator calculator = new Calculator(loanInsurance, loanCost);


            Console.WriteLine("\n");
            Console.WriteLine("*** Assurance ***");
            Console.WriteLine($"Coût mensuel           : { loanInsurance.CalculateMonthlyLoanInsuranceCost() }");
            Console.WriteLine($"Coût total            : { loanInsurance.CalculateTotalLoanInsuranceCost() }");
            Console.WriteLine("\n");
            Console.WriteLine("*** Emprunt ***");
            Console.WriteLine($"Coût mensuel           : { loanCost.CalculateMonthlyLoanCost() }");
            Console.WriteLine($"Coût total             : { loanCost.CalculateTotalLoanCost() }");
            Console.WriteLine($" -> Part des intérêts  : { loanCost.CalculateTotalLoanInterestCost() }");
            Console.WriteLine("\n");
            Console.WriteLine($"Coût mensuel total     : { calculator.CalculateMonthlyCost() }");
            Console.WriteLine("\n \n");

            Console.WriteLine("Saisiez le nombre de mois que vous avez payé pour connaître le capital déjà remboursé : ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine($"Capital de remboursé   : { loanCost.CalculateMonthlyLoanCostWithoutInterest(month) }");
        }
    }
}