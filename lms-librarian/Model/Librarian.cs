using lms_common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_librarian.Model
{
    internal class Librarian
    {
        [lms_common.PrimaryKey] private string? nic = null;
        private string? name = null;
        private string? password = null;

        public string? NIC { get { return nic; } set { nic = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public string? Password { get { return password; } set { password = value; } } 
    }
}
