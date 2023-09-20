using lms_client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lms_client.View
{
    public partial class BorrowRequestForm : Form
    {
        BorrowRequestController requestController;

        public BorrowRequestForm()
        {
            InitializeComponent();
            requestController  = new BorrowRequestController();
        }

        private void UpdateListView()
        {
            listView.Items.Clear();
            var requests = requestController.GetBorrowRequests();
            foreach (var request in requests)
            {
                ListViewItem item = new ListViewItem(request.RequestedUserNIC);
                item.SubItems.Add(request.RequestedBookISBN);
                item.SubItems.Add(request.RequestDate.ToString());
                item.SubItems.Add(request.ReviewDate.ToString());
                item.SubItems.Add(request.Approved.ToString());
                listView.Items.Add(item);
            }
        }


        private void BorrowRequestForm_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                requestController.CancelBurrowRequest(
                    new lms_common.Model.BorrowRequest
                    {
                        RequestedUserNIC = listView.SelectedItems[0].Text,
                        RequestedBookISBN = listView.SelectedItems[0].SubItems[1].Text,
                        RequestDate = null,
                        ReviewDate = null,
                        Approved = null
                    }
                );
            }
            UpdateListView();
        }
    }
}
