using lms_librarian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_librarian.Controller
{
    internal class UserController
    {
        public List<lms_common.Model.User> GetUsers(lms_common.Model.User user)
        {
            var users = Model.LmsLibrarianApplication.Instance.Database.SelectFrom(user);

            return users;
        }

        public void AddUser(lms_common.Model.User user)
        {
            Model.LmsLibrarianApplication.Instance.Database.InsertInto(user);
        }

        public void RemoveUser(lms_common.Model.User user)
        {
            Model.LmsLibrarianApplication.Instance.Database.DeleteFrom(user);
        }
    }
}
