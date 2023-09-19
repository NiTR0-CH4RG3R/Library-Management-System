using lms_librarian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_librarian.Controller
{
    internal class LibrarianController
    {
        public bool Authenticate(Model.Librarian librarian)
        {
            return LmsLibrarianApplication.Instance.Authenticate(librarian);
        }

        public Model.Librarian GetAuthenticatedLibrarian()
        {
            return LmsLibrarianApplication.Instance.AuthenticatedLibrarian; ;
        }
    }
}
