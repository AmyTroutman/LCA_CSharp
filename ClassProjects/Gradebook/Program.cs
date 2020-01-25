using System;
using System.Collections.Generic;

namespace Gradebook
{
    class MainClass
    {

        public static string grades;
        public static string newGrades;
        //public string processedGrades;

        public static void Main()
        {
            string student;
            bool hasQuit = false;
            Dictionary<string, string> studentRecord = new Dictionary<string, string>();
            do
            {
                Console.WriteLine("Enter Student's name. If you are done entering all students, type quit.");
                student = Console.ReadLine().ToUpper();

                if (student == "QUIT")
                {
                    hasQuit = true;
                }
                else
                {
                    Console.WriteLine("Enter the student's grades, separated by a space (example: 100 90 97 85).");
                    grades = Console.ReadLine();
                    ProcessGrades(grades);
                   
                    try
                    {
                        studentRecord.Add(student, newGrades);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Student already exists.");
                    }

                }
            }
            while (hasQuit == false);
            PrintGradebook(studentRecord);
        }

        public static void ProcessGrades(string grades)
        {
            try
            {
                int highest = 0;
                int lowest = 100;
                int average = 0;
                int sum = 0;
                //int average = 0;

                //first, split the values into an array, split on " "
                string[] gradeArray = grades.Split(' ');

                //convert to int

                int[] numGradeArray = Array.ConvertAll(gradeArray, s => int.Parse(s));
                //find the highest grade, save to int highest

                foreach (var i in numGradeArray)
                {
                    if (i > highest)
                    {
                        highest = i;
                    }
                }

                //find the lowest grade, save to int lowest

                foreach (var i in numGradeArray)
                {
                    if (i < lowest)
                    {
                        lowest = i;
                    }
                }

                //find the average, save to int average
                foreach (var i in numGradeArray)
                {
                    sum += i;
                }
                average = sum / numGradeArray.Length;


                //Console.WriteLine(processedGrades);
                newGrades = "Highest grade: " + highest + ". Lowest grade: " + lowest + ". Average grade: " + average + ".";
            }
            catch
            {
                Console.WriteLine("I think one of those wasn't a number!");
            }
        }

        public static void PrintGradebook(Dictionary<string, string> studentRecord)
        {
            //print it
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in studentRecord)
            {
                Console.WriteLine("{0} {1}",
                    kvp.Key, kvp.Value);
            }

        }
    }
}
