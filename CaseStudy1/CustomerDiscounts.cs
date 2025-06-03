using System;
 
class Customer { }
class PremiumCustomer : Customer
{
    public void GetDiscount()
    {
        Console.WriteLine("Discount applied for premium customer.");
    }
}
 
public class CustomerDiscounts
{
    public static void Run()
    {
        Customer cust = new PremiumCustomer();
 
        PremiumCustomer premium = cust as PremiumCustomer;
        if (premium != null)
            premium.GetDiscount();
        else
            Console.WriteLine("No discount available.");
    }
}