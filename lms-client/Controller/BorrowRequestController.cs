using lms_client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_client.Controller
{
    internal class BorrowRequestController
    {
        public List<lms_common.Model.BorrowRequest> GetBorrowRequests()
        {
            return LmsClientApplication.Instance.Database.SelectFrom(new lms_common.Model.BorrowRequest
            {
                RequestedUserNIC = LmsClientApplication.Instance.AuthenticatedUser.NIC,
                RequestedBookISBN = null,
                RequestDate = null,
                ReviewDate = null,
                Approved = null
            }) ;
            
        }

        public void MakeBurrowRequest( lms_common.Model.Book book )
        {
            LmsClientApplication.Instance.Database.InsertInto(new lms_common.Model.BorrowRequest
            {
                RequestedUserNIC = LmsClientApplication.Instance.AuthenticatedUser.NIC,
                RequestedBookISBN = book.ISBN,
                RequestDate = DateTime.Now,
                ReviewDate = null,
                Approved = null
            });
        }

        public void CancelBurrowRequest( lms_common.Model.BorrowRequest request )
        {
            var requests = LmsClientApplication.Instance.Database.SelectFrom(request);
            foreach ( var r in requests )
            {
                if ( r.Approved != true )
                {
                    LmsClientApplication.Instance.Database.DeleteFrom(r);
                }
            }
        }
    }
}
