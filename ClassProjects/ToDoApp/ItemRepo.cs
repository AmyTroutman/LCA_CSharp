using System;
using System.Collections.Generic;
using System.Linq;
using static ToDoApp.ConsoleUtils;


namespace ToDoApp
{
    public class ItemRepository
    {
        public static ItemContext context = new ItemContext();
        public bool success = false;
        public ItemRepository()
        {
            context.Database.EnsureCreated();
        }

        //public static List<ToDoItem> GetList(string status)
        //{
        //    IEnumerable<ToDoItem> itemList; //create list
        //    if (status != null) //filter status 
        //    {
        //        itemList = context.ToDoList.Where(x => x.Status == status);
        //    }
        //    else
        //    {
        //        itemList = context.ToDoList;
        //    }
        //    return (itemList.ToList());
        //}

        public static void AddTask()
        {
            ToDoItem newTask = new ToDoItem(NewPrompt());
            context.ToDoList.Add(newTask);
            context.SaveChanges();
        }

        public static void DeleteTask()
        {
            ToDoItem DeleteTask = context.ToDoList.Where(x => x.ID == DeletePrompt()).FirstOrDefault();
            context.Remove(DeleteTask);
            context.SaveChanges();
        }

        public static void DoneTask()
        {
            ToDoItem DoneTask = context.ToDoList.Where(x => x.ID == DonePrompt()).FirstOrDefault();
            
            if (DoneTask != null) //if found
            {
                DoneTask.Status = DoneTask.Status == "Pending" ? "Done" : "Pending"; //change status if pending then finished or finished then pending
                context.Update(DoneTask); //change status
                context.SaveChanges(); // commit changes
                DoneReply();
            }
            else
            {
                
            }
        }
    }
}

//Acts as the interface between your application and the database that store
//the ToDoItems. This class is responsible for managing the list of items and
//how it is saved and fetched from the database.
