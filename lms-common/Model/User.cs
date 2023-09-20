using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_common.Model
{
    public class User
    {
        [PrimaryKey] private string? nic = null;
        private string? name = null;
        private string? phone = null;
        private string? address = null;
        private string? password = null;

        public string? NIC { get => nic; set => nic = value; }
        public string? Name { get => name; set => name = value; }
        public string? Phone { get => phone; set => phone = value; }
        public string? Address { get => address; set => address = value; }
        public string? Password { get => password; set => password = value; }
    }
}
