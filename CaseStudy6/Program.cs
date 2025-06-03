﻿using System;

namespace CaseStudy6
{
    class Program
    {
        static void Main()
        {
            // 1. Factorial
            try
            {
                Factorial fact = new Factorial();
                Console.Write("Enter a number for factorial: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int result = fact.CalculateFactorial(num);
                Console.WriteLine($"Factorial of {num} is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in factorial: {ex.Message}");
            }

            // 2. Simple Interest
            try
            {
                SimpleInterest si = new SimpleInterest();
                Console.WriteLine("\nSimple Interest Calculation:");
                Console.Write("Principal: ");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Time: ");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.Write("Rate: ");
                double r = Convert.ToDouble(Console.ReadLine());

                double interest = si.CalculateSI(p, t, r);
                Console.WriteLine($"Simple Interest: {interest}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SI calculation: {ex.Message}");
            }

            // 3. Simple Interest using out parameters
            try
            {
                SimpleInterestOut siOut = new SimpleInterestOut();
                Console.WriteLine("\nSI and Total Amount (using out parameters):");
                Console.Write("Principal: ");
                double p2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Time: ");
                double t2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Rate: ");
                double r2 = Convert.ToDouble(Console.ReadLine());

                siOut.Calculate(p2, t2, r2, out double siVal, out double total);
                Console.WriteLine($"Interest: {siVal}, Total Amount: {total}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SI with out parameters: {ex.Message}");
            }

            // 4. Simple Interest using Optional Parameter
            try
            {
                SimpleInterestOptional siOpt = new SimpleInterestOptional();
                Console.WriteLine("\nSI with Optional Rate (default 10%):");
                Console.Write("Principal: ");
                double p3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Time: ");
                double t3 = Convert.ToDouble(Console.ReadLine());

                double siResult = siOpt.CalculateSI(p3, t3); // rate omitted, default 10 used
                Console.WriteLine($"Simple Interest (default rate): {siResult}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SI with optional parameter: {ex.Message}");
            }
        }
    }
}
