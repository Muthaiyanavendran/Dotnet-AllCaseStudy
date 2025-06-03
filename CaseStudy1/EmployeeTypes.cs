using System;
 
class Employee { }
class Manager : Employee { }
class Developer : Employee { }
class Intern : Employee { }
 
public class EmployeeTypes
{
   public static void Run()
    {
        Employee emp = new Developer();
 
        if (emp is Manager)
            Console.WriteLine("Role: Manager");
        else if (emp is Developer)
            Console.WriteLine("Role: Developer");
        else if (emp is Intern)
            Console.WriteLine("Role: Intern");
        else
            Console.WriteLine("Role: Unknown");
    }
}
 