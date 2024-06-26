using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMTLoaningCompany
{
    internal class CreateLoans
    {
        static void Main(string[] args)
        {

            //creates an array of 5 loans
            string[,] fiveLoans = new string[7,5];


            //asks for current prime interest rate
            Console.WriteLine($"----------------{LoanConstants.companyName}-----------------------");
            Console.WriteLine(" ");
            Console.Write("Enter current prime interest rate(use a comma for a decimal): ");
            double primeInterestRate = double.Parse(Console.ReadLine());


            //asks for loan type in a loop
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Customer {x+1}");
                typeOfLoan(primeInterestRate, x, fiveLoans);
            }
            

            displayingAllLoans(5, fiveLoans);


        }

        //displays the loans
        public static void displayingAllLoans(int colom, string[,] arr)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"------------ALL LOANS-----------------------");
            
            
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine($"------------Customer {x+1}-----------------------");

                int termEntered = int.Parse(arr[4, x]);
                DateTime todayDate = DateTime.Now;
                DateTime dateDue = todayDate.AddYears(termEntered);
                string noTime = dateDue.ToString("yyyy-MM-dd");

                Console.WriteLine($"Loan number    : {arr[0, x]}\nName           : {arr[2, x]} {arr[1, x]}\nType of Loan   : {arr[6, x]}\nAmount borrowed: R{arr[3, x]}\nAmount Due     : R{arr[5, x]}\nDue Date       : {noTime}");
            }
        }

        public static void typeOfLoan( double InterestRate, int numOfColoms, string[,] arr)
        {
            Console.WriteLine("----------------------------------");
            Console.Write("What type of loan would you like to create(Personal/Business): ");
            string loanType = Console.ReadLine();

            if ((loanType == "business") || (loanType == "Business") || (loanType == "b") || (loanType == "B"))
            {
               
                Capturing( InterestRate, arr, numOfColoms, 2);
            }

            else if ((loanType == "personal") || (loanType == "Personal") || (loanType == "p") || (loanType == "P"))
            {
                
                Capturing(InterestRate, arr, numOfColoms, 1);
            }

            else
            {
                Console.WriteLine("Please enter either Business or Personal");
                typeOfLoan( InterestRate, numOfColoms, arr);
            }
        }

        public static void Capturing(double interestRate, string[,] arr, int numberOfColoumnArray, int typeOfLoan)
        {
            //assigning random value for the the loan number
            Random randomNum = new Random();

            int ELoannumber = randomNum.Next(1111,9999);

            //asks for the loan details
            Console.WriteLine("------------------------------------");
            Console.Write("Please enter you firstname: ");
            string EFirstName = Console.ReadLine();
            Console.Write("Please enter your lastname: ");
            string ELastName = Console.ReadLine();
            Console.Write("Please enter the loan amount: ");
            double ELoanAmount1 = double.Parse(Console.ReadLine());
            double ELoanAmount = Math.Round(ELoanAmount1, 2);
            Console.Write("Please enter the loan term in years(1/3/5): ");
            int ELoanTerm = int.Parse(Console.ReadLine());
            


            //adding details to the array
            arr[0, numberOfColoumnArray] = ELoannumber.ToString();
            arr[1, numberOfColoumnArray] = ELastName.ToString();
            arr[2, numberOfColoumnArray] = EFirstName.ToString();
            arr[3, numberOfColoumnArray] = ELoanAmount.ToString("0.00");
            arr[4, numberOfColoumnArray] = ELoanTerm.ToString();


            if(typeOfLoan == 1)
            {
                PersonalLoan customerPLoan = new PersonalLoan(ELoannumber, ELastName, EFirstName, ELoanAmount, ELoanTerm);
                Console.WriteLine(customerPLoan.ToString());
                double amountDueToStore = customerPLoan.AmountDue(interestRate, ELoanAmount, ELoanTerm);
                arr[5, numberOfColoumnArray] = amountDueToStore.ToString("0.00");
                arr[6, numberOfColoumnArray] = "Personal";
            }
            else if(typeOfLoan == 2)
            {
                BusinessLoan customerBLoan = new BusinessLoan(ELoannumber, ELastName, EFirstName, ELoanAmount, ELoanTerm);
                Console.WriteLine(customerBLoan.ToString());
                double amountDueToStore = customerBLoan.AmountDue(interestRate, ELoanAmount, ELoanTerm);
                arr[5, numberOfColoumnArray] = amountDueToStore.ToString("0.00");
                arr[6, numberOfColoumnArray] = "Business";
            }

            else
            {
                PersonalLoan customerPLoan = new PersonalLoan(ELoannumber, ELastName, EFirstName, ELoanAmount, ELoanTerm);
                Console.WriteLine(customerPLoan.ToString());
                double amountDueToStore = customerPLoan.AmountDue(interestRate, ELoanAmount, ELoanTerm);
                arr[5, numberOfColoumnArray] = amountDueToStore.ToString("0.00");
                arr[6, numberOfColoumnArray] = "Personal";
            }
        }
    }
}
