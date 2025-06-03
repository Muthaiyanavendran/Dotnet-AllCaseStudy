using System;

namespace CaseStudy4
{
    public class JaggedTestScores
    {
        string[] subjects = { "Math", "Science", "English" };
        int[][] scores = new int[3][];

        public JaggedTestScores()
        {
            scores[0] = new int[] { 80, 85, 90 };          // Math
            scores[1] = new int[] { 75, 78 };              // Science
            scores[2] = new int[] { 88, 84, 79, 91 };       // English
        }

        public void DisplayScores()
        {
            Console.WriteLine("\nTest Scores (Jagged Array):");

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"\nSubject: {subjects[i]}");
                Console.Write("Scores: ");
                int sum = 0;
                foreach (int score in scores[i])
                {
                    Console.Write(score + " ");
                    sum += score;
                }
                double avg = sum / (double)scores[i].Length;
                Console.WriteLine($"\nAverage: {avg:F2}");
            }
        }
    }
}
