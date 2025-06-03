using System;

namespace CaseStudy3
{
    public class SalaryIncrement
    {
        public void CalculateSalary()
        {
            Console.Write("\nEnter an Initial Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an Increment Rate (%): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSalary Increment for the next 5 years:");
            for (int year = 1; year <= 5; year++)
            {
                salary += salary * (rate / 100);
                Console.WriteLine($"Year {year}: ₹{salary:F2}");
            }
        }
    }
}
