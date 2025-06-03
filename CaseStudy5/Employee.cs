using System;

namespace CaseStudy5
{
    public class Employee { }

    public class Manager : Employee { }

    public class Developer : Employee { }

    public class Intern : Employee { }

    public class EmployeeIdentifier
    {
        public void Identify(Employee emp)
        {
            if (emp is Manager)
                Console.WriteLine("This is a Manager.");
            else if (emp is Developer)
                Console.WriteLine("This is a Developer.");
            else if (emp is Intern)
                Console.WriteLine("This is an Intern.");
            else
                Console.WriteLine("Unknown Employee Type.");
        }
    }
}
