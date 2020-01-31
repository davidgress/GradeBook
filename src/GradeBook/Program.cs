﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        { 
            var book = new Book("Dave's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"Average: {stats.Average:N1}");
            Console.WriteLine($"Lowest Grade: {stats.Low:N1}");
            Console.WriteLine($"Highest Grade: {stats.High:N1}");
        }
    }
}
