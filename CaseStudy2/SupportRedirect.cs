using System;

namespace CaseStudy2
{
    public class SupportRedirect
    {
        public void Redirect()
        {
            Console.Write("\nEnter Department Number (1-Billing, 2-Technical, 3-Sales): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Redirecting to Billing Department...");
                    break;
                case 2:
                    Console.WriteLine("Redirecting to Technical Support...");
                    break;
                case 3:
                    Console.WriteLine("Redirecting to Sales...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
