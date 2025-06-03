using System;

namespace CaseStudy6
{
    public class SimpleInterestOptional
    {
        public double CalculateSI(double principal, double time, double rate = 10)
        {
            if (principal < 0 || time < 0 || rate < 0)
                throw new ArgumentException("Values cannot be negative.");

            return (principal * time * rate) / 100;
        }
    }
}
