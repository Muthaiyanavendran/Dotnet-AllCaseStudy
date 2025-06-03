﻿using System;

namespace CaseStudy3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Case Study 3: Looping Constructs ===");

            // 1. Salary Increment using for loop
            SalaryIncrement salaryIncrement = new SalaryIncrement();
            salaryIncrement.CalculateSalary();

            // 2. Stock Monitoring using while loop
            StockMonitor stockMonitor = new StockMonitor();
            stockMonitor.MonitorPrice();

            // 3. Product Inventory using foreach loop
            InventoryCheck inventoryCheck = new InventoryCheck();
            inventoryCheck.CheckProducts();
        }
    }
}
