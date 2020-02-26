using System;
using static ToDoApp.ConsoleUtils;
using static ToDoApp.ItemRepository;
namespace ToDoApp
{
    public class App
    {
        public bool isDone;
        private ItemRepository itemRepository;
        public ConsoleUtils consoleUtils;

        public App()
        {
            itemRepository = new ItemRepository();
            consoleUtils = new ConsoleUtils();
        }

        public void Start()
        {
            do
            {          
                Menu();
                string input = GetInput();
                switch(input)
                {
                    case "addItem":
                        //call add method
                        //NewPrompt();
                        AddTask();
                    break;

                    case "deleteItem":
                        //DeletePrompt();
                        DeleteTask();
                    break;

                    case "markDone":
                        //call method
                        //DonePrompt();
                        DoneTask();
                    break;

                    case "printAll":
                        //Todo: call method
                        
                    break;

                    case "printActive":
                        //todo: call method
                        GetList("pending");
                        PrintActive();
                        break;

                    case "printInactive":
                        //Todo: call method
                    break;
                    case "quit":                        
                        isDone = true; //stop program
                    break;
                }
            } while (isDone == false);
            Quit();
        }

        public void Quit()
        {                            
            ConsoleUtils.QuitPrint();
            Console.ReadKey();
        }
    }
}
//The brains that manages all the rules and coordinates the user interactions
//and the database interactions. Should not directly update the database,
//but should go through the ItemRepository class.
