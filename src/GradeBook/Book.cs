
using System;
using System.Collections.Generic;

namespace GradeBook {
    public class Book {
        List<double> grades;
        public string Name;

        public Book(string name) {
            this.grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade) {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;  
            }
            result.Average /= grades.Count;
            return result;
        }
    }
    
}