﻿using System;

namespace CaseStudy5
{
    class Program
    {
        static void Main()
        {
            // Employee Type Identification
            Console.WriteLine("Employee Role Identification using 'is':");
            EmployeeIdentifier identifier = new EmployeeIdentifier();

            Employee e1 = new Manager();
            Employee e2 = new Developer();
            Employee e3 = new Intern();
            Employee e4 = new Employee();

            identifier.Identify(e1);
            identifier.Identify(e2);
            identifier.Identify(e3);
            identifier.Identify(e4);

            // Student Management
            StudentManager manager = new StudentManager();
            manager.AddStudent(new Student(1, "Alice"));
            manager.AddStudent(new Student(2, "Bob"));
            manager.AddStudent(new Student(3, "Charlie"));

            manager.DisplayAll();

            Console.Write("\nEnter name to search: ");
            string searchName = Console.ReadLine();
            manager.SearchStudent(searchName);

            Console.Write("\nEnter name to remove: ");
            string removeName = Console.ReadLine();
            manager.RemoveStudent(removeName);

            Console.WriteLine("\nUpdated List of Students:");
            manager.DisplayAll();

            manager.CountStudents();
        }
    }
}
