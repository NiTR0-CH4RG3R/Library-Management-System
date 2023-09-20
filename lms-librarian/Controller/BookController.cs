using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_librarian.Controller
{
    internal class BookController
    {
        List<lms_common.Model.Book> GetBooks(lms_common.Model.Book book)
        {
            var books = new List<lms_common.Model.Book>();
            // Logic for getting books from the database through Application layer
            return books;
        }

        lms_common.Model.Book GetBookByISBN(string ISBN)
        {
            return new lms_common.Model.Book();
        }

        void AddBook(lms_common.Model.Book book)
        {

        }

        void RemoveBook(lms_common.Model.Book book)
        {

        }
    }
}
