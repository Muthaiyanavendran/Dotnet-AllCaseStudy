using System;
 
public class OrderProcessing
{
    public static void Run()
    {
        object price1 = 100; // boxing
        object price2 = 200; // boxing
 
        int total = (int)price1 + (int)price2; // unboxing
        Console.WriteLine("Total price: " + total);
    }
}
 