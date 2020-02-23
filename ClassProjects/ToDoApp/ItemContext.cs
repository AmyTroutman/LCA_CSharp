using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoApp
{
    class ItemContext : DbContext
    {        
        public DbSet<ToDoItem> ToDoList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the directory the code is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            // get the base directory for the project
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            // add 'library.db' to the project directory
            String DatabaseFile = Path.Combine(ProjectBase.FullName, "todolist.db");

            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :"+DatabaseFile);

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }    
}
