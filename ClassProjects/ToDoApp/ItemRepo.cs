using System;
using System.Collections.Generic;
using System.Linq;
using static ToDoApp.ConsoleUtils;

namespace ToDoApp
{
    public class ItemRepository
    {
        public static ItemContext context = new ItemContext();

        public ItemRepository()
        {
            context.Database.EnsureCreated();
        }

        //public static (List<ToDoItem>, int) GetList(string status) //create list
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
        //}

        public static void AddTask()
        {
            ToDoItem newTask = new ToDoItem(NewPrompt());
            context.ToDoList.Add(newTask);
            context.SaveChanges();
        }

        public static void DeleteTask()
        {
            context.Remove(DeletePrompt());
            context.SaveChanges();
        }

        public static void DoneTask()
        {
            context.Update(DonePrompt());
            context.SaveChanges();
        }
    }
}

//Acts as the interface between your application and the database that store
//the ToDoItems. This class is responsible for managing the list of items and
//how it is saved and fetched from the database.
