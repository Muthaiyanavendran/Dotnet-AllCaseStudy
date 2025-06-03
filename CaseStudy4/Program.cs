﻿using System;

namespace CaseStudy4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Case Study 4: Arrays ===");

            // 1. Product Search
            ProductSearch productSearch = new ProductSearch();
            productSearch.SearchProduct();

            // 2. Student Marks (2D Array)
            StudentMarks2D studentMarks = new StudentMarks2D();
            studentMarks.DisplayStudentMarks();

            // 3. Jagged Array for Test Scores
            JaggedTestScores testScores = new JaggedTestScores();
            testScores.DisplayScores();
        }
    }
}
