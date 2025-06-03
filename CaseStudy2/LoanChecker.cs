using System;

namespace CaseStudy2
{
    public class LoanChecker
    {
        public void CheckEligibility()
        {
            Console.Write("\nEnter Credit Score: ");
            int creditScore = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Income: ");
            int income = Convert.ToInt32(Console.ReadLine());

            if (creditScore >= 700 && income >= 30000)
                Console.WriteLine("Loan Approved");
            else
                Console.WriteLine("Loan Rejected");
        }
    }
}
