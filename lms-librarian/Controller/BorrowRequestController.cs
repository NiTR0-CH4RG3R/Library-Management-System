using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_librarian.Controller
{
    internal class BorrowRequestController
    {
        List<lms_common.Model.BorrowRequest> GetBorrowRequests()
        {
            var requests = new List<lms_common.Model.BorrowRequest>();

            return requests;
        }


        void ApproveBurrowRequest(lms_common.Model.BorrowRequest request)
        {

        }

        void DisapproveBurrowRequest(lms_common.Model.BorrowRequest request)
        {

        }
    }
}
