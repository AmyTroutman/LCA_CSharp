using System;
namespace ToDoApp
{
    public class ToDoItem
    {
        public int ID { get; private set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public ToDoItem(string description)
        {
            this.Description = description;
            //Pending by default, because surely I'm the only person who adds
            //finished tasks to my list to make myself feel like I'm accomplishing a lot.
            Status = "PENDING";
        }
    }
}
