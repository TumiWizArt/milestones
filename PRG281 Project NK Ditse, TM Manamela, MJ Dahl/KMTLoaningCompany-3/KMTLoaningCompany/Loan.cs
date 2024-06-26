using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KMTLoaningCompany
{
    public abstract class Loan: LoanConstants
    {
        private int _loanNumber;
        public int loanNumber
        {
            get { return _loanNumber; }
            set { _loanNumber = value;}
        }

        private string _lastName;
        public string customerLastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _firstName;
        public string customerFirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private double _loanAmount;
        public double loanAmount
        {
            get { return _loanAmount; }
            set { _loanAmount = value; }
        }

        private double _interestRate;
        public double interestRate
        {
            get { return _loanAmount; }
            set { _loanAmount = value; }
        }

        private int _term;
        public int term
        {
            get { return _term; }
            set { _term = value; }
        }
        
        

        public Loan(int loanNumber, string lastName, string firstName, double loanAmount, int term )
        {
            this.loanNumber = loanNumber;
            this.customerLastName = lastName;
            this.customerFirstName = firstName;

            //restriction of loan amounts greater than 100 000
            if (loanAmount <= 100000)
            {
                this.loanAmount = loanAmount;
            }
            else
            {
                Console.WriteLine("Loan amounts greater than R100 000 are not allowed");
                
            }

            //setting loan amounts that are not either short, medium or long to default to short
            if ((term == LoanConstants.longTerm) || (term == LoanConstants.mediumTerm) || (term == LoanConstants.shortTerm))
            {
                this.term = term;

            }
            else
            {
                this.term = LoanConstants.shortTerm;
            }
        }


        public override string ToString()
        {
            return ($"\nA customer with the following details has been created\n----------------------------------------\nLoan number  : {loanNumber}\nCustomer name: {customerFirstName} {customerLastName}\nLoan amount  : {loanAmount}\nLoan term    : {term}");
        }

    }

        
    }

