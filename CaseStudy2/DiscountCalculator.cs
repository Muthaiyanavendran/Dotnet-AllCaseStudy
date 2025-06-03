using System;

namespace CaseStudy2
{
    public class DiscountCalculator
    {
        public void CalculateFinalBill()
        {
            Console.Write("\nEnter Total Bill Amount: ₹");
            double bill = Convert.ToDouble(Console.ReadLine());

            double finalAmount = bill >= 5000 ? bill * 0.8 : bill;
            Console.WriteLine($"Final Bill Amount: ₹{finalAmount:F0}");
        }
    }
}
