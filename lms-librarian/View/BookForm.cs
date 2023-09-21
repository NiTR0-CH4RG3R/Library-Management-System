using lms_librarian.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms_librarian.View
{
    public partial class BookForm : Form
    {
        private Controller.BookController bookController;

        public BookForm()
        {
            InitializeComponent();
            bookController = new Controller.BookController();
        }

        lms_common.Model.Book GetBookFromForm()
        {
            string? isbn = String.IsNullOrWhiteSpace(textBoxISBN.Text) ? null : textBoxISBN.Text;
            string? title = String.IsNullOrWhiteSpace(textBoxTitle.Text) ? null : textBoxTitle.Text;
            string? author = String.IsNullOrWhiteSpace(textBoxAuthor.Text) ? null : textBoxAuthor.Text;
            int? qty = String.IsNullOrWhiteSpace(textBoxQty.Text) ? null : Convert.ToInt32(textBoxQty.Text);

            return new lms_common.Model.Book { ISBN = isbn, Title = title, Author = author, Qty = qty };
        }

        private void RefreshListView()
        {
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bookController.AddBook(GetBookFromForm());
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if ( listView.SelectedItems.Count > 0 )
                bookController.RemoveBook(
                    new lms_common.Model.Book { ISBN = listView.SelectedItems[0].Text, Title = null, Author = null, Qty = null }
                );
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }
    }
}
