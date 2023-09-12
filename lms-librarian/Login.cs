using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms_librarian
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show(); 
        }
    }
}
