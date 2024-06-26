using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMTLoaningCompany
{
    internal class BusinessLoan : Loan
    {
        public BusinessLoan(int loanNumber, string lastName, string firstName, double loanAmount, int term) : base(loanNumber, lastName, firstName, loanAmount, term)
        {
           
        }

        public double AmountDue(double primeInterestRate, double loanAmount, int term)
        {
            //increasing the prime interst rate by 1%
            double increasedBy2 = (primeInterestRate/100) * (1 / 100);
            double totalInterestRate = (primeInterestRate/100) + increasedBy2;

            //calculating the total amount due
            double totalInterest = loanAmount * totalInterestRate * term;
            double dueAmount = loanAmount + totalInterest;
            return dueAmount;
        }
    }
}
