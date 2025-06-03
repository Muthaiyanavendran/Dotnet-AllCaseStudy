using System;

namespace CaseStudy2
{
    public class PasswordTracker
    {
        public void TrackPassword()
        {
            string correctPassword = "CSharp@123";
            int attempts = 3;

        Start:
            if (attempts == 0)
            {
                Console.WriteLine("Account Locked!");
                return;
            }

            Console.Write("Enter Password: ");
            string input = Console.ReadLine();

            if (input == correctPassword)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                attempts--;
                if (attempts > 0)
                {
                    Console.WriteLine($"Incorrect Password! {attempts} attempts left.");
                    goto Start;
                }
                else
                {
                    goto Start;
                }
            }
        }
    }
}
