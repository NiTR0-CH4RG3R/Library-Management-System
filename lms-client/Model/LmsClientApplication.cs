using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_client.Model
{
    internal class LmsClientApplication
    {
        private static LmsClientApplication? instance = null;
        public static LmsClientApplication Instance
        {
            get { 
                if ( instance == null ) instance = new LmsClientApplication();
                return instance; 
            }
        }
        private LmsClientApplication()
        {
            // Initialize the database
            _database = new lms_common.Database(_databaseUsername, _databasePassword);
        }

        public bool Authenticate(lms_common.Model.User user)
        {
            if (_authenticated) return true;

            var users = _database.SelectFrom(user);
            if (users.Any())
            {
                _authenticated = true;
                _authenticatedUser = user;
            }

            return _authenticated;
        }


        private string _databaseUsername = "";
        private string _databasePassword = "";
        private lms_common.Database _database;

        private bool _authenticated = false;
        lms_common.Model.User _authenticatedUser = new lms_common.Model.User();


        public bool IsAuthenticated { get { return _authenticated; } }
        public lms_common.Database Database { get { return _database; } }
        public lms_common.Model.User AuthenticatedUser { get { return _authenticatedUser; } }




    }
}
