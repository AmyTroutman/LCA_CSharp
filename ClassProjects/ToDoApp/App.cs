﻿using System;
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

        #region DisplayAll Method        
        private void DisplayAll()
        {
            string printType = "ALL";

            List<ToDoItem> List = ItemRepo.GetList(printType);
            ConsoleUtil.PrintList(List);
        }
        #endregion

        private void DisplayDone()
        {
            string printType = "DONE";
            List<ToDoItem> list = ItemRepo.GetList(printType);
            ConsoleUtil.PrintList(list);
        }


        #region DisplayFilter Method
        //method that handles filtering
        //calls the filter method from console to prompt filter selection
        //switch statement handles multiple scenarios based on command given
        private void DisplayFilter()
        {            
            //string filter = PrintPrompt();

            switch (PrintPrompt())
            {
                case "DONE":
                    DisplayDone();
                    break;

                case "PENDING":
                    List<ToDoItem> PendingList = ItemRepo.GetList("PENDING");
                    ConsoleUtil.PrintList(PendingList);
                    break;

                case "ALL":
                    //List<ToDoItem> AllList = ItemRepo.GetList("ALL");
                    //ConsoleUtil.PrintList(AllList);
                    DisplayAll();
                    break;

                default:
                    FailReply();
                    break;
            }
        }
        #endregion

        public void Start()
        {
            DisplayAll();
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

                    case "printList":
                        //Todo: call method
                        DisplayFilter();                        
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