using System;

namespace MyLibrary
{
    public class Brain
    {
        private Catalog catalog;
        public MouthEars mouthEars;

        public Brain()
        {
            catalog = new Catalog();
            mouthEars = new MouthEars();
        }
        #region starter
        public void Start(){
            Console.WriteLine("Welcome to Amy's book database!");
           
            bool done = false;
            do
            {
                MouthEars.MainMenu();
                switch (MouthEars.MenuInput())
                    {
                    case "addBook":
                        MouthEars.TitlePrompt();
                        MouthEars.AuthorPrompt();
                        MouthEars.GenrePrompt();
                        Catalog.NewBook();                       
                        break;
                    case "deleteBook": 
                        PrintLibrary();
                        MouthEars.IdPrompt();
                        Catalog.DeleteBook();                        
                        break;
                    case "updateBook":
                        PrintLibrary();
                        MouthEars.IdPrompt();
                        Catalog.UpdateBook();                        
                        break;
                    case "sortLibrary":
                        MouthEars.SortPrompt();
                        SortBook();
                        PrintLibrary(SortBook());                        
                        break;
                    case "quit":
                        MouthEars.QuitPrint();
                        done = true;
                        break;
                    default:
                        MouthEars.BadPrint();
                        break;
                }
            } while (done == false);
        }
        #endregion
    }
}
