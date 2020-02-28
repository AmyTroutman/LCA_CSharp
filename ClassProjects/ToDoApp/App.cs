using System;
using System.Collections.Generic;
using static ToDoApp.ConsoleUtils;
using static ToDoApp.ItemRepository;

namespace ToDoApp
{
    public class App
    {
        public bool isDone;
        private ItemRepository ItemRepo;
        public ConsoleUtils ConsoleUtil;

        public App()
        {
            ItemRepo = new ItemRepository();
            ConsoleUtil = new ConsoleUtils();
        }

        #region PrintFilter Method
        
        private void PrintFilter()
        {            
            string filter = PrintPrompt();
            
            switch (filter)
            {
                case "DONE":
                    List<ToDoItem> DoneList = ItemRepo.GetList("DONE");
                    ConsoleUtil.PrintList(DoneList);
                    break;

                case "PENDING":
                    List<ToDoItem> PendingList = ItemRepo.GetList("PENDING");
                    ConsoleUtil.PrintList(PendingList);
                    break;

                case "ALL":
                    List<ToDoItem> AllList = ItemRepo.GetList("ALL");
                    ConsoleUtil.PrintList(AllList);                    
                    break;

                default:
                    FailReply();
                    break;
            }
        }
        #endregion

        public void Start()
        {
            ConsoleUtil.PrintList(ItemRepo.GetList("ALL"));
            do
            {          
                Menu();
                string input = GetInput();
                switch(input)
                {
                    case "addItem":                        
                        AddTask();
                    break;

                    case "deleteItem":
                        Console.Clear();
                        ConsoleUtil.PrintList(ItemRepo.GetList("ALL"));
                        DeleteTask();
                    break;

                    case "markDone":
                        Console.Clear();
                        ConsoleUtil.PrintList(ItemRepo.GetList("ALL"));
                        DoneTask();
                    break;

                    case "printList":
                        //Todo: call method
                        PrintFilter();                        
                    break;                    

                    case "quit":                        
                        isDone = true; //stop program
                    break;

                    default:
                    break;
                }
            } while (isDone == false);
            Quit();
        }

        public void Quit()
        {                            
            QuitPrint();
            Console.ReadKey();
        }
    }
}
//The brains that manages all the rules and coordinates the user interactions
//and the database interactions. Should not directly update the database,
//but should go through the ItemRepository class.
