using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lms_librarian.View
{
    public partial class ClientForm : Form
    {
        private Controller.UserController userController;

        public ClientForm()
        {
            InitializeComponent();

            userController = new Controller.UserController();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string? name = String.IsNullOrWhiteSpace(textBoxName.Text) ? null : textBoxName.Text;
            string? nic = String.IsNullOrWhiteSpace(textBoxNIC.Text) ? null : textBoxNIC.Text;
            string? contact = String.IsNullOrWhiteSpace(textBoxContact.Text) ? null : textBoxContact.Text;
            string? address = String.IsNullOrWhiteSpace(textBoxAddress.Text) ? null : textBoxAddress.Text;
            string? password = String.IsNullOrWhiteSpace(textBoxPassword.Text) ? null : textBoxPassword.Text;

            userController.AddUser(new lms_common.Model.User { NIC=nic, Name=name, Phone=contact, Address=address, Password=password });
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //string name = textBoxName.Text;
            //string nic = textBoxNIC.Text;
            //string contact = textBoxContact.Text;
            //string address = textBoxAddress.Text;
            //string password = textBoxPassword.Text;
            string? name = String.IsNullOrWhiteSpace(textBoxName.Text) ? null : textBoxName.Text;
            string? nic = String.IsNullOrWhiteSpace(textBoxNIC.Text) ? null : textBoxNIC.Text;
            string? contact = String.IsNullOrWhiteSpace(textBoxContact.Text) ? null : textBoxContact.Text;
            string? address = String.IsNullOrWhiteSpace(textBoxAddress.Text) ? null : textBoxAddress.Text;
            string? password = String.IsNullOrWhiteSpace(textBoxPassword.Text) ? null : textBoxPassword.Text;

            var users = userController.GetUsers(new lms_common.Model.User { NIC=nic, Name=name, Phone=contact, Address=address, Password=password });

            foreach( var user in users )
            {
                ListViewItem item = new ListViewItem(user.NIC);
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Phone);
                item.SubItems.Add(user.Address);
                item.SubItems.Add(user.Password);
                listView.Items.Add(item);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            if (listView.SelectedItems.Count > 0)
            {
                string nic = listView.SelectedItems[0].Text;
                userController.RemoveUser(new lms_common.Model.User { NIC=nic, Name=null, Phone=null, Address=null, Password=null });
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
