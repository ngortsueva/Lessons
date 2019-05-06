using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Ninject;

namespace BooksConsole
{
    class Program
    {        
        static void Main(string[] args)
        {
            string provider = ConfigurationSettings.AppSettings["provider"];
            string cnStr = ConfigurationSettings.AppSettings["cnStr"];

            IBookRepository repository = new DbBookRepository(provider, cnStr);
                        
            //insert book
            Book book1 = new Book { Title = "book1", Isbn = "qwerty", Description = "book1", AuthorId =1 };
            Book book2 = new Book { Title = "book2", Isbn = "qwerty", Description = "book2", AuthorId = 1 };
            Book book3 = new Book { Title = "book3", Isbn = "qwerty", Description = "book3", AuthorId = 1 };

            repository.AddBook(book1);
            repository.AddBook(book2);
            repository.AddBook(book3);            
            repository.Save();
            repository.Print();            
            Console.WriteLine("--------------------");

            book1.Title = "My Book 1";
            repository.UpdateBook(book1);
            repository.Save();
            repository.Print();
            Console.WriteLine("--------------------");

            
            repository.DeleteBook(book1);
            repository.DeleteBook(book2);
            repository.DeleteBook(book3);            
            repository.Save();            
            repository.Print();
            Console.WriteLine("Count books in list: {0}", repository.Books.Count());
            
            Console.ReadLine();
          
        }
        
    }
}
