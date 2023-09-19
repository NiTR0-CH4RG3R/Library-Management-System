using lms_client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_client.Controller
{
    internal class UserController
    {
        public bool Authenticate( lms_common.Model.User user )
        {
            return LmsClientApplication.Instance.Authenticate(user);
        }

        public lms_common.Model.User GetAuthenticatedUser()
        {
            return LmsClientApplication.Instance.AuthenticatedUser;
        }
    }
}
