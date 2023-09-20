using lms_client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_client.Controller
{
    internal class BookController
    {
        public List<lms_common.Model.Book> GetBooks(lms_common.Model.Book book)
        {
            return LmsClientApplication.Instance.Database.SelectFrom(book) ;
        }

        public lms_common.Model.Book GetBookByISBN(string ISBN)
        {
            return new lms_common.Model.Book();
        }
    }
}
