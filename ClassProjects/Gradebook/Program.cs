using System;
using System.Collections.Generic;

namespace Gradebook
{
    class MainClass
    {


        public static void Main()
        {
            string student;
            string grades;
            bool hasQuit = false;
            Dictionary<string, string> studentRecord = new Dictionary<string, string>();
            do
            {
                Console.WriteLine("Enter Student's name. If you are done entering all students, type quit.");
                student = Console.ReadLine().ToLower();

                if (student == "quit")
                {
                    hasQuit = true;
                }
                else
                {
                    Console.WriteLine("Enter the student's grades, separated by a space (example: 100 90 97 85).");
                    grades = Console.ReadLine();
                    //try catch here to check for duplicate student
                    studentRecord.Add(student, grades);                    
                }
            }
            while (hasQuit == false);

            ProcessGrades(studentRecord);
            PrintGradebook(studentRecord);
        }
        public static void ProcessGrades(Dictionary<string, string> studentRecord)
        {
            int highest;
            int lowest;
            int average;
            //one big foreach loop around highest, lowest, average
            /*foreach (var key in studentRecord.Keys)
               {
                   foreach (var grade in studentRecord[key])
                   {
                        //I want to grab the values(grades) and convert to ints
                        //first, copy the value to an array
                        string[] gradeArray = grade;
                        //second, split the values into an int array, split on " "
                        string splitGradeArray = gradeArray.Split(" ");
                        int [] numGradeArray = splitGradeArray.TryParse(Int32);
                        //find the highest grade, save to int highest
            
                        foreach (var i in numGradeArray)
                        {
                            if (i > highest)
                            {
                                i = highest;
                            }
                        }

                        //find the lowest grade, save to int lowest
            
                        foreach (var i in array)
                        {
                            if (i < lowest)
                            {
                                i = lowest;
                            }
                        }

                        //find the average, save to int average

                        //convert highest, lowest, average to strings

                        //concatenate highest, lowest, and average
                        string processedGrades = highestStr + lowestStr + averageStr;

                    }
                    //replace orignal value with new string
                        studentRecord[key] = processedGrades;
                }
                */
        }
        public static void PrintGradebook(Dictionary<string, string> studentRecord)
        {
            //print it
            /*
            foreach (var key in studentRecord.Keys)
            {
                Console.WriteLine("Student: " + key);
                foreach (var grade in studentRecord[key])
                {
                    Console.WriteLine(grade);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            */
        }
    }
}
