using System;

class Program
{
    static void Main(string[] args)
    {
        // Full Time Employee
        FullTimeEmployee fte = new FullTimeEmployee
        {
            EmpCode = 101,
            EmpName = "Alice Johnson",
            Email = "alice@abctech.com",
            DeptName = "Development",
            Location = "Chennai",
            Basic = 50000
        };

        fte.CalculateSalary();
        Console.WriteLine(fte.PrintEmployeeDetails(fte));

        // Part Time Employee
        PartTimeEmployee pte = new PartTimeEmployee
        {
            EmpCode = 202,
            EmpName = "Bob Smith",
            Email = "bob@abctech.com",
            DeptName = "Testing",
            Location = "Pondicherry",
            Basic = 20000
        };

        pte.CalculateSalary();
        Console.WriteLine(pte.PrintEmployeeDetails(pte));
    }
}
