using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BooksConsole
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }
        void AddBook(Book book);
        void DeleteBook(Book book);
        void UpdateBook(Book book);
        void Save();
        void Print();        
    }    
}
