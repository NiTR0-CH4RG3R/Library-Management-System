using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms_common.View
{
    public partial class Login : Form
    {
        private string _username = string.Empty;
        private string _password = string.Empty;

        public Login()
        {
            InitializeComponent();
        }

        public string Username { get { return _username; } }
        public string Password { get { return _password; } }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _username = textBoxUsername.Text;
            _password = textBoxPassword.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
