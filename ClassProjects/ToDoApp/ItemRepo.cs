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

        /// <summary>
        /// Creates a list from db based on the filter returned from PrintPrompt.
        /// </summary>
        /// <param name="printType">From PrintPrompt: All, Done, Pending</param>
        /// <returns>
        /// Returns the list associated with the printType.
        /// </returns>        
        public List<ToDoItem> GetList(string printType)
        {
            List<ToDoItem> FilterList = new List<ToDoItem>().ToList();
            if (printType == "ALL")
            {
                FilterList = context.ToDoList.ToList(); 
            }
            else if (printType == "DONE")
            {
                FilterList = context.ToDoList.Where(x => x.Status == "DONE").ToList();
            }
            else if (printType == "PENDING")
            {
                FilterList = context.ToDoList.Where(x => x.Status == "PENDING").ToList();
            }
            return FilterList;
        }

        #region Tasks
        /// <summary>
        /// Uses AddPrompt return to add a new task to the list.
        /// </summary>     
        public static void AddTask()
        {            
            ToDoItem newTask = new ToDoItem(AddPrompt());            
                context.ToDoList.Add(newTask);
                context.SaveChanges();
                DoneReply();                     
        }

        /// <summary>
        /// Uses IDPrompt return to get the ID of the task to be deleted.
        /// Deletes the task.
        /// </summary>
        public static void DeleteTask()
        {
            ToDoItem DeleteTask = context.ToDoList.Where(x => x.ID == IDPrompt()).FirstOrDefault();
            if (DeleteTask != null)
            {
                context.Remove(DeleteTask);
                context.SaveChanges();
                DoneReply();
            }
            else
            {
                FailReply();
            }
        }

        /// <summary>
        /// Uses IDPrompt return to get the ID of the task to be updated.
        /// Changes status from pending to done, or done to pending
        /// </summary>
        public static void DoneTask()
        {
            ToDoItem DoneTask = context.ToDoList.Where(x => x.ID == IDPrompt()).FirstOrDefault();
            
            if (DoneTask != null)
            {
                DoneTask.Status = DoneTask.Status == "PENDING" ? "DONE" : "PENDING";
                context.Update(DoneTask); 
                context.SaveChanges(); 
                DoneReply();
            }
            else
            {
                FailReply();
            }
        }
        #endregion
    }
}


//CLASS RESPONSIILITIES
//Acts as the interface between your application and the database that store
//the ToDoItems. This class is responsible for managing the list of items and
//how it is saved and fetched from the database.
