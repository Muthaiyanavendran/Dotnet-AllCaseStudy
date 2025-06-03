using System;

namespace CaseStudy4
{
    public class ProductSearch
    {
        string[] products = { "Laptop", "Smartphone", "Tablet", "Monitor", "Keyboard" };

        public void SearchProduct()
        {
            Console.Write("\nEnter product to search: ");
            string input = Console.ReadLine();

            bool found = false;
            foreach (string product in products)
            {
                if (product.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
            }

            Console.WriteLine(found ? "Product is Available." : "Product is Not Available.");
        }
    }
}
