using System;
 
public class CurrencyConversion
{
    public static void Run()
    {
        int amount = 150;
        double converted = (double)amount; // convert to double
        Console.WriteLine("Converted to double: " + converted);
 
        // Round and convert back
        int rounded = (int)Math.Round(converted);
        Console.WriteLine("Rounded back to int: " + rounded);
    }
}