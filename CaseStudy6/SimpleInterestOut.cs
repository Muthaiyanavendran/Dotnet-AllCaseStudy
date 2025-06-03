using System;

namespace CaseStudy6
{
    public class SimpleInterestOut
    {
        public void Calculate(double principal, double time, double rate, out double interest, out double totalAmount)
        {
            if (principal < 0 || time < 0 || rate < 0)
                throw new ArgumentException("Values cannot be negative.");

            interest = (principal * time * rate) / 100;
            totalAmount = principal + interest;
        }
    }
}
