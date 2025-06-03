using System;

namespace CaseStudy6
{
    public class SimpleInterest
    {
        public double CalculateSI(double principal, double time, double rate)
        {
            if (principal < 0 || time < 0 || rate < 0)
                throw new ArgumentException("Values cannot be negative.");

            return (principal * time * rate) / 100;
        }
    }
}
