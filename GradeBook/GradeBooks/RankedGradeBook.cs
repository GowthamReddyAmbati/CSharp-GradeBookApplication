﻿using System;
using GradeBook.Enums;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(String name):base(name)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count<5)
            {
                throw new InvalidOperationException();
            }
            var threshold = (int)Math.Ceiling(Students.Count * 0.20);
            var grades = Students.OrderByDescending(e=>e.AverageGrade).Select(e=>e.AverageGrade).ToList();
            if (grades[threshold - 1] <= averageGrade)
            {
                return 'A';
            }
            else if (grades[(threshold * 2) - 1] <= averageGrade)
            {
                return 'B';
            }
            else if (grades[(threshold * 2) - 1] <= averageGrade)
            {
                return 'B';
            }
            else if (grades[(threshold * 3) - 1] <= averageGrade)
            {
                return 'C';
            }
            else if (grades[(threshold * 4) - 1] <= averageGrade)
            {
                return 'D';
            }
            else
                return 'F';
            
        }


        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}