using lms_common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_librarian.Controller
{
    internal class BookController
    {
        public List<lms_common.Model.Book> GetBooks(lms_common.Model.Book book)
        {
            // Logic for validating the book object
            var books = Model.LmsLibrarianApplication.Instance.Database.SelectFrom(book);
            return books;
        }

        public lms_common.Model.Book GetBookByISBN(string ISBN)
        {
            // Logic for validating the ISBN
            return Model.LmsLibrarianApplication.Instance.Database.SelectFrom(new lms_common.Model.Book { ISBN = ISBN, Author = null, Title = null, Qty = null })[0];
        }

        public void AddBook(lms_common.Model.Book book)
        {
            Model.LmsLibrarianApplication.Instance.Database.InsertInto(book);
        }

        public void RemoveBook(lms_common.Model.Book book)
        {
            Model.LmsLibrarianApplication.Instance.Database.DeleteFrom(book);
        }
    }
}
