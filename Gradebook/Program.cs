using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create list to hold names and grades
            //need to add 'new' to create an empty string for a new list
            //need to specify the same type in the list object (first) and the list constructor (second)
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            //collect names of each student in class to put in list
            //utilize a do-while loop
            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    //.add() method is part of the List class
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades using one type of for loop
            //must declare iterator variable 'student'
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            // Print roster using another type of for loop
            //use a loop index
            //use property students.Count (gives integer representing number of items in list)
            Console.WriteLine("\nClass roster:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + " (" + grades[i] + ")");
            }

            //compute average grade for all students
            //.Sum() returns sum of all items in list
            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}