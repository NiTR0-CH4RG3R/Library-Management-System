using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lms_common
{
    public class Database
    {
        private string databaseHost = "DESKTOP-TGA2QCA";
        private string databasePort = "";
        private string databaseName = "LibraryManagementSystem";

        private string databaseUsername = "";
        private string databasePassword = "";

        private SqlConnection _connection;

        public Database(string databaseUsername, string databasePassword)
        {
            this.databaseUsername = databaseUsername;
            this.databasePassword = databasePassword;

            string connetionString = $@"Data Source={databaseHost};Initial Catalog={databaseName};User ID={this.databaseUsername};Password={this.databasePassword}";
            // Data Source=DESKTOP-TGA2QCA;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

        }

    }
}
