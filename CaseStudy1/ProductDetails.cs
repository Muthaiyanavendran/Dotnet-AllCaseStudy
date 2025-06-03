using System;
 
class Laptop
{
    public const double TaxRate = 0.18; // constant
    public readonly int ManufactureYear; // readonly
 
    public Laptop(int year)
    {
        ManufactureYear = year;
    }
 
    public void ShowDetails()
    {
        Console.WriteLine("Tax Rate: " + TaxRate);
        Console.WriteLine("Manufacture Year: " + ManufactureYear);
    }
}
 
// class Program
// {
//     static void Main()
//     {
//         Laptop l = new Laptop(2023);
//         l.ShowDetails();
//     }
// }