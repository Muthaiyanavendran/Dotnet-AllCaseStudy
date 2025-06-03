using System;

namespace CaseStudy4
{
    public class StudentMarks2D
    {
        string[] students = { "Alice", "Bob", "Charlie" };
        string[] subjects = { "Math", "English", "Science" };

        int[,] marks = {
            { 85, 90, 78 },
            { 75, 80, 88 },
            { 92, 81, 76 }
        };

        public void DisplayStudentMarks()
        {
            Console.WriteLine("\nStudent Marks (2D Array):");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nStudent: {students[i]}");
                int total = 0;

                Console.Write("Marks: ");
                for (int j = 0; j < subjects.Length; j++)
                {
                    Console.Write(marks[i, j] + " ");
                    total += marks[i, j];
                }

                double avg = total / (double)subjects.Length;
                Console.WriteLine($"\nTotal: {total}");
                Console.WriteLine($"Average: {avg:F2}");
            }
        }
    }
}
