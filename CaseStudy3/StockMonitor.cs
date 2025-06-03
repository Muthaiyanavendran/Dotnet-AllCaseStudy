using System;

namespace CaseStudy3
{
    public class StockMonitor
    {
        public void MonitorPrice()
        {
            Console.Write("\nEnter a Stock Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a Target Price: ");
            double target = Convert.ToDouble(Console.ReadLine());

            int day = 1;
            Console.WriteLine("\nMonitoring stock prices:");
            while (price < target)
            {
                Console.WriteLine($"Day {day}: Stock Price = ₹{price:F0}");
                price += 5;
                day++;
            }

            Console.WriteLine($"Day {day}: Stock Price = ₹{price:F0}");
            Console.WriteLine($"\nStock price exceeded ₹{target:F0} on Day {day}");
        }
    }
}
