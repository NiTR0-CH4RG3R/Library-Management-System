using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_librarian.Model
{
    internal class LmsLibrarianApplication
    {
        private static LmsLibrarianApplication? instance = null;

        public static LmsLibrarianApplication Instance
        {
            get {
                if (instance == null) instance = new LmsLibrarianApplication();
                return instance;
            }
        }

        private LmsLibrarianApplication()
        {
            // Initialize the database
            _database = new lms_common.Database(_databaseUsername, _databasePassword);
        }

        public bool Authenticate(Model.Librarian librarian)
        {
            if (_authenticated) return true;
            // Authentication logic goes here

            _authenticatedLibrarian = librarian;
            return _authenticated;
        }

        private string _databaseUsername = "";
        private string _databasePassword = "";
        private lms_common.Database _database;

        private bool _authenticated = false;
        Model.Librarian _authenticatedLibrarian = new Model.Librarian();

        public bool IsAuthenticated { get { return _authenticated; } }
        public lms_common.Database Database { get { return _database; } }
        public Model.Librarian AuthenticatedLibrarian { get { return _authenticatedLibrarian; } }
    }
}
