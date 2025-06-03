class Program{
 
    static void Main(String[] args){
        Console.WriteLine("----------------------");
        Console.WriteLine("EmployeeTypes");
        EmployeeTypes.Run();
 
        Console.WriteLine("----------------------");
        Console.WriteLine("Customer Discounts");
        CustomerDiscounts.Run();
 
        Console.WriteLine("----------------------");
        Console.WriteLine("Currency Conversion");
        CurrencyConversion.Run();
 
        Console.WriteLine("----------------------");
        Console.WriteLine("Order Processing");
        OrderProcessing.Run();
 
    Console.WriteLine("----------------------");
    Console.WriteLine("Product Details");
 
        Laptop l = new Laptop(2023);
        l.ShowDetails();
 
    }
}