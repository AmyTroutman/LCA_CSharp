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

        #region Print Methods
        /// <summary>
        /// Takes the input from PrintPrompt and runs it through a switch.
        /// Got hung up here for a while because it was looking for UPPER words,
        /// but ToDoItem and ItemRepo were setting them as Normal.
        /// Thus it was never finding a match, but also not throwing an error.     
        /// </summary>
        private void PrintFilter()
        {            
            string filter = PrintPrompt();
            
            switch (filter)
            {
                case "DONE":
                    List<ToDoItem> DoneList = ItemRepo.GetList(filter);
                    ConsoleUtil.PrintList(DoneList);
                    break;

                case "PENDING":
                    List<ToDoItem> PendingList = ItemRepo.GetList(filter);
                    ConsoleUtil.PrintList(PendingList);
                    break;

                case "ALL":
                    List<ToDoItem> AllList = ItemRepo.GetList(filter);
                    ConsoleUtil.PrintList(AllList);                    
                    break;

                default:
                    FailReply();
                    break;
            }
        }

        /// <summary>
        /// Some super nesting to simply print the full list. Probs could be done more simply.
        /// </summary>
        private void PrintAll()
        {
            ConsoleUtil.PrintList(ItemRepo.GetList("ALL"));
        }
        #endregion

        #region Motor starter
        /// <summary>
        /// Prints list (maybe remove) prints menu.
        /// Grabs input and calls the associated methods.
        /// Stops once isDone is true.
        /// </summary>
        public void Start()
        {
            PrintAll();
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
                        PrintAll();
                        DeleteTask();
                    break;

                    case "markDone":
                        Console.Clear();
                        PrintAll();
                        DoneTask();
                    break;

                    case "printList":                       
                        PrintFilter();                        
                    break;                    

                    case "quit":                        
                        isDone = true;
                    break;

                    default:
                    break;
                }
            } while (isDone == false);
            QuitPrint();
        }
        #endregion
    }
}

//CLASS RESPONSIBILITIES
//The brains that manages all the rules and coordinates the user interactions
//and the database interactions. Should not directly update the database,
//but should go through the ItemRepository class.
