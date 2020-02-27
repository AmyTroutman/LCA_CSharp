using System;
namespace ToDoApp
{
    public class ToDoItem
    {
        public int ID { get; private set; }
        public string Task { get; set; }
        public string Status { get; set; }

        public ToDoItem(string task)
        {
            this.Task = task;
            //Pending by default, because surely I'm the only person who adds
            //finished tasks to my list to make myself feel like I'm accomplishing a lot.
            Status = "Pending";
        }
    }
}
