using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_common.Model
{
    public class BorrowRequest
    {
        [PrimaryKey] private string? u_nic = null;
        [PrimaryKey] private string? b_isbn = null;
        private DateTime? requestDate = null;
        private DateTime? reviewDate = null;
        private bool? approved = null;

        public string? RequestedUserNIC { get => u_nic; set => u_nic = value; }
        public string? RequestedBookISBN { get => b_isbn; set => b_isbn = value; }
        public DateTime? RequestDate { get => requestDate; set => requestDate = value; }
        public DateTime? ReviewDate { get => reviewDate; set => reviewDate = value; }
        public bool? Approved { get => approved; set => approved = value; }
    }
}
