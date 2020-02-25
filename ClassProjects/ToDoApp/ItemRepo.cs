using System;
using System.Collections.Generic;
using System.Linq;
using static ToDoApp.ConsoleUtils;

namespace ToDoApp
{
    public class ItemRepository
    {
        static ItemContext context = new ItemContext();

        public ItemRepository()
        {
            context.Database.EnsureCreated();
        }       

        public static void AddTask(string task)
        {
            ToDoItem newTask = new ToDoItem(task);
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
