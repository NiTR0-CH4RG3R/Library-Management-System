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
    public partial class Dashboard : Form
    {
        Controller.UserController userController;
        public Dashboard()
        {
            InitializeComponent();
            userController = new Controller.UserController();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Authentication Code
            lms_common.View.Login login = new lms_common.View.Login();
            login.ShowDialog(this);

            if ( 
                userController.Authenticate(
                    new lms_common.Model.User { 
                        NIC = login.Username, 
                        Name = null, 
                        Phone = null, 
                        Address = null, 
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
            

            labelGreeting.Text = $"Welcome! {userController.GetAuthenticatedUser().Name}";

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            this.Hide();
            BrowseForm form = new BrowseForm();
            form.FormClosed += (s, e) => { this.Show(); };
            form.Show();
        }

        private void buttonBurrowRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new BorrowRequestForm();
            form.FormClosed += (s, e) => { this.Show(); };
            form.Show();
        }
    }
}
