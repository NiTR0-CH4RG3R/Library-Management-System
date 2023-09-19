using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_client.Controller
{
    internal class BorrowRequestController
    {
        List<lms_common.Model.BorrowRequest> GetBorrowRequests()
        {
            var requests = new List<lms_common.Model.BorrowRequest>();
            return requests;
        }

        lms_common.Model.BorrowRequest MakeBurrowRequest( lms_common.Model.Book book )
        {
            return new lms_common.Model.BorrowRequest();
        }

        void CancelBurrowRequest( lms_common.Model.BorrowRequest request )
        {

        }
    }
}
