using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksConsole
{
    interface IAuthorRepository
    {
        IQueryable<Author> Authors { get; }
        void AddAuthor(Author author);
        void DeleteAuthor(Author author);
        void UpdateAuthor(Author author);
        void Clear();
    }
}
