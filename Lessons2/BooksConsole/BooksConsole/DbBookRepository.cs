using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace BooksConsole
{
    public class DbBookRepository : IBookRepository
    {
        private string provider;
        private string strConnection;
        private DbProviderFactory df;
        private DbConnection cn;
        private DbCommand cmd;
        private string sql;
        private List<Book> books = new List<Book>();
               
        public DbBookRepository(string provider, string connection) {
            this.provider = provider;
            this.strConnection = connection;

            df = DbProviderFactories.GetFactory(provider);

            cn = df.CreateConnection();

            cn.ConnectionString = strConnection;

            cn.Open();

            cmd = df.CreateCommand();

            cmd.Connection = cn;
        }

        private void read_data()
        {
            books.Clear();

            cmd.CommandText = "select * from Books";

            try
            {
                DbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Book book = new Book
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Title = dr["title"].ToString(),
                        Isbn = dr["isbn"].ToString(),
                        Description = dr["description"].ToString(),
                        AuthorId = int.Parse(dr["authorid"].ToString())
                    };
                    books.Add(book);
                }
                dr.Close();
            }
            catch(DbException e) {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        private void clear_data()
        {
            try
            {
                cmd.CommandText = "delete from Books";
                cmd.ExecuteNonQuery();
            }
            catch (DbException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        private void insert_data()
        {
            foreach (Book book in books)
            {
                sql = string.Format("insert into Books (title, isbn, description, authorid) values('{0}','{1}','{2}','{3}')",
                                     book.Title, book.Isbn, book.Description, book.AuthorId);
                try
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = string.Format("select id from Books where title='{0}'", book.Title);
                    DbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read()) book.Id = int.Parse(dr["id"].ToString());

                    dr.Close();
                }
                catch (DbException e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
        }

        public IEnumerable<Book> Books {
            get { return books; }
        }

        public void AddBook(Book book) {
            books.Add(book);
        }

        public void DeleteBook(Book book) {
            books.Remove(book);
        }

        public void UpdateBook(Book book) {
            foreach (Book item in books)
            {
                if (item.Id == book.Id)
                {
                    item.Title = book.Title;
                    item.Isbn = book.Isbn;
                    item.Description = book.Description;
                    item.AuthorId = book.AuthorId;
                }
            }
        }

        public void Save() {
            clear_data();
            insert_data();
        }

        public void Print()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
