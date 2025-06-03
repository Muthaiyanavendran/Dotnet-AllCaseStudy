﻿using System;

namespace CaseStudy2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Case Study 2: Decision Making Constructs ===");

            // 1. Loan Eligibility
            LoanChecker loan = new LoanChecker();
            loan.CheckEligibility();

            // 2. Customer Support System
            SupportRedirect support = new SupportRedirect();
            support.Redirect();

            // 3. Password Tracker
            PasswordTracker tracker = new PasswordTracker();
            tracker.TrackPassword();

            // 4. Discount Calculator
            DiscountCalculator discount = new DiscountCalculator();
            discount.CalculateFinalBill();
        }
    }
}
