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
    public partial class Dashboard : Form
    {
        Controller.LibrarianController librarianController;
        public Dashboard()
        {
            InitializeComponent();
            librarianController = new Controller.LibrarianController();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Authentication Logic goes here
            lms_common.View.Login login = new lms_common.View.Login();
            login.ShowDialog(this);
            if (
                librarianController.Authenticate(
                    new Model.Librarian
                    {
                        NIC = login.Username,
                        Name = null,
                        Password = login.Password
                    }
                    )
                )
            {
                MessageBox.Show(this, "ACCESS GRANTED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "ACCESS DENIED!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            labelGreeting.Text = $"Welcome! {librarianController.GetAuthenticatedLibrarian().Name}";

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ClientForm();
            form.FormClosed += (s, e) => this.Show();
            form.Show();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new BookForm();
            form.FormClosed += (s, e) => this.Show();
            form.Show();
        }

        private void buttonBurrowRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new BorrowrequestForm();
            form.FormClosed += (s, e) => this.Show();
            form.Show();
        }

    }
}
