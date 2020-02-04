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
                Console.WriteLine("When do you need to get this done by?");
                string date = Console.ReadLine();
                Console.WriteLine("And how important is this? (high, medium, low)");
                string pri = Console.ReadLine();
                Console.WriteLine("Do you need to do anything else?");
                string noMore = Console.ReadLine().ToLower();
                if (noMore == "no")
                {
                    imDone = true;
                }                               
                ToDoList MyList = new ToDoList(task, date, pri);
                //it's erasing masterlist when it gets here. why??
                //it wasn't STATIC! now it 'members. le sigh of relief...
                MyList.ListOfLists();                                
            } while (imDone == false);
            //fuck me, just make everything static. want to use an outside method? it better be STATIC! Want that list to remember everything? Make it STATIC!
            ToDoList.PrintAll();
        }
        
    }
    class ToDoList
    {
        public string Task;
        public string Date;
        public string Priority;        
        public static List<List<string>> MasterList = new List<List<string>>();
        public ToDoList(string getTask, string getDate, string getPri)
        {
            Task = getTask;
            Date = getDate;
            Priority = getPri;
        }
        public void ListOfLists()
        {
            MasterList.Add(new List<string>{Task});
            MasterList.Add(new List<string> { Date });
            MasterList.Add(new List<string> { Priority });            
        }
        public static void PrintAll()
        {            
            Console.WriteLine("Alrighty! Here's your ToDo list:");
            Console.WriteLine("");
            foreach (List<string> list in MasterList)
            {                
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }               
            }
            Console.WriteLine("");
            Console.WriteLine("Get to work!");
        }
    }
}
