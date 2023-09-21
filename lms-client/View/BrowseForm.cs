using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms_client.View
{
    public partial class BrowseForm : Form
    {
        Controller.BookController bookController;
        Controller.BorrowRequestController requestController;
        Controller.UserController userController;
        public BrowseForm()
        {
            InitializeComponent();
            bookController = new Controller.BookController();
            requestController = new Controller.BorrowRequestController();
            userController = new Controller.UserController();
        }

        private void RefreshListView()
        {
            listView.Items.Clear();
            var books = bookController.GetBooks(GetBookFromForm());

            foreach (var book in books)
            {
                ListViewItem item = new ListViewItem(book.ISBN);
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Qty.ToString());
                listView.Items.Add(item);
            }
        }

        private lms_common.Model.Book GetBookFromForm()
        {
            var GetNullOrEmpty = ( string str ) => String.IsNullOrEmpty(str) ? null : str;
            string? isbn = GetNullOrEmpty(textBoxISBN.Text);
            string? title = GetNullOrEmpty(textBoxTitle.Text);
            string? author = GetNullOrEmpty(textBoxAuthor.Text);

            return new lms_common.Model.Book
            {
                ISBN = isbn,
                Title = title,
                Author = author,
                Qty = null
            };
        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void buttonBurrow_Click(object sender, EventArgs e)
        {
            if( listView.SelectedItems.Count > 0 )
            {
                requestController.MakeBurrowRequest(
                    new lms_common.Model.Book
                    {
                        ISBN = listView.SelectedItems[0].Text,
                        Title = null,
                        Author = null,
                        Qty = null
                    }
                );
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
