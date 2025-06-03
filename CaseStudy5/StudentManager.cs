using System;
using System.Collections.Generic;
using System.Linq;

namespace CaseStudy5
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayAll()
        {
            Console.WriteLine("\nAll Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
            }
        }

        public void SearchStudent(string name)
        {
            var student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (student != null)
                Console.WriteLine($"Found: ID={student.ID}, Name={student.Name}");
            else
                Console.WriteLine("Student not found.");
        }

        public void RemoveStudent(string name)
        {
            var student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void CountStudents()
        {
            Console.WriteLine($"Total number of students: {students.Count}");
        }
    }
}
