using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BooksConsole
{
    public class SqlBookRepository : IBookRepository
    {
        private string provider;
        private string strConnection;
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private string sql;
        private List<Book> books = new List<Book>();

        public SqlBookRepository(string con)
        {
            this.strConnection = con;

            sqlConnection = new SqlConnection(strConnection);

            sqlConnection.Open();

            sqlCommand = new SqlCommand();

            sqlCommand.Connection = sqlConnection;

            read_data();
        }

        private void read_data()
        {
            books.Clear();

            sql = "select * from Books";

            try 
            {
                sqlCommand.CommandText = sql;

                SqlDataReader dr = sqlCommand.ExecuteReader();

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
            catch (SqlException e) {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        //----------------------------------------------------------------
        private void clear_data()
        {
            sql = "delete from Books";

            try {
                sqlCommand.CommandText = sql;
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e) {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        private void insert_data()
        {
            foreach (Book book in books) {
                sql = string.Format("insert into Books (title, isbn, description, authorid) values('{0}','{1}','{2}','{3}')",
                                     book.Title, book.Isbn, book.Description, book.AuthorId);
                try {
                    sqlCommand.CommandText = sql;
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.CommandText = string.Format("select id from Books where title='{0}'", book.Title);
                    SqlDataReader dr = sqlCommand.ExecuteReader();

                    if(dr.Read()) book.Id = int.Parse(dr["id"].ToString());

                    dr.Close();
                }
                catch (SqlException e) {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
        }

        public void Save()
        {            
            clear_data();
            insert_data();
        }

        public IEnumerable<Book> Books
        {
            get { return books; }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DeleteBook(Book book)
        {
            books.Remove(book);
        }

        public void UpdateBook(Book book)
        {
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

        public void Print()
        {
            Console.WriteLine("***Print books:");
            foreach (Book book in Books)
            {
                Console.WriteLine(book.ToString());
            }
        }        
    }
}
