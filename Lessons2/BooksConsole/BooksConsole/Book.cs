using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksConsole
{
    public class Book
    {
        public int? Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }        
        public string Description { get; set; }
        public string ToString()
        {
            return string.Format("Id: {0}, Title: {1}, Isbn: {2}, Description: {3}, AuthorId: {4}", Id, Title, Isbn, Description, AuthorId);
        }
    }
}
