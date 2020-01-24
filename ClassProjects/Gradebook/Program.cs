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
            Dictionary<string, string> studentRecord = new Dictionary<string, string>();
            do
            {
                Console.WriteLine("Enter Student's name. If you are done entering all students, type quit.");
                student = Console.ReadLine().ToLower();

                //try catch here to check for quit
                if (student == "quit")
                {
                    break;
                }

                Console.WriteLine("Enter the student's grades, separated by a space (example: 100 90 97 85).");
                grades = Console.ReadLine();
                studentRecord.Add(student, grades);
                Console.WriteLine(studentRecord[student]);
            }
            //this isn't working, but the if/break is working
            while (student != "quit");

            ProcessGrades(studentRecord);
            PrintGradebook(studentRecord);
        }
        public static void ProcessGrades(Dictionary<string, string> studentRecord)
        {
            //one big foreach loop around highest, lowest, average
            //I want to grab the values(grades) and convert to ints
            //first, copy the value to an array
            //second, split the values into an int array, split on " "

            //find the highest grade, save to int highest, add to key
            /*
            foreach (var i in array)
            {
                if (i > highest)
                {
                    i = highest;
                }
            }
            
            */

            //find the lowest grade, save to int lowest, add to key
            /*
            foreach (var i in array)
            {
                if (i < lowest)
                {
                    i = lowest;
                }
            }
            
            */
            //find the average, save to int average, add to key


            //concatenate highest, lowest, and average

            //convert to a string

            //replace orignal value with new string

            
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
