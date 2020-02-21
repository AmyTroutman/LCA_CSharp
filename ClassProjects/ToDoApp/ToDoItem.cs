using System;
namespace ToDoApp
{
    public class ToDoItem
    {
        public int ID { get; private set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public ToDoItem(string description, string status)
        {
            this.Description = description;
            this.Status = status;
        }
    }
}
