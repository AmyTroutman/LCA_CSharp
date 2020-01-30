using System;
using System.Collections.Generic;

namespace ToDoList
{
    class MainClass
    {
         
        public static void Main(string[] args)
        {
            bool imDone = false;
            Console.WriteLine("Let's make a list!");
            do
            {
                Console.WriteLine("What do you need to do?");
                string task = Console.ReadLine();
                Console.WriteLine("When do you need to get this done by? (mm/dd/yy)");
                string date = Console.ReadLine();
                Console.WriteLine("And how important is this? (high, medium, low)");
                string pri = Console.ReadLine();
                Console.WriteLine("Do you need to do anything else?");
                string noMore = Console.ReadLine().ToLower();
                if (noMore == "no")
                {
                    imDone = true;
                }
                else
                {
                    //method from MakeList class to add task, date, and priority
                    //as value to a list
                    MakeList myList = new MakeList(task, date, pri);
                    myList.AddList();
                }
            } while (imDone == false);
            //
        }
        
    }
    class MakeList
    {
        public string Task;
        public string Date;
        public string Priority;
        public MakeList(string getTask, string getDate, string getPri)
        {
            Task = getTask;
            Date = getDate;
            Priority = getPri;
        }
        public void AddList()
        {
            List<string> todo = new List<string>();
        }
    }
}
