using System;
namespace ToDoApp
{
    public class App
    {
        public bool isDone;

        public App()
        {
        }

        public void Start()
        {
            do
            {
                Menu();
            } while (isDone == false);
        }

        public void Quit()
        {
            if (isDone == true)
            {
                ItemRepo.Save();
                Console.ReadKey();
            }
        }
    }
}
//The brains that manages all the rules and coordinates the user interactions
//and the database interactions. Should not directly update the database,
//but should go through the ItemRepository class.
