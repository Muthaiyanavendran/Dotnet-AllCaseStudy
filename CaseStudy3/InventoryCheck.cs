using System;

namespace CaseStudy3
{
    public class InventoryCheck
    {
        public void CheckProducts()
        {
            string[] products = { "Laptop", "Smartphone", "Headphones", "Tablet", "Smartwatch" };
            string[] outOfStock = { "Smartphone", "Tablet" };

            Console.WriteLine("\nChecking product availability:");
            foreach (string product in products)
            {
                bool isOut = Array.Exists(outOfStock, p => p.Equals(product, StringComparison.OrdinalIgnoreCase));
                Console.WriteLine($"{product}: {(isOut ? "Out of Stock" : "In Stock")}");
            }
        }
    }
}
