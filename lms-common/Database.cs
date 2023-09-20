using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using System.Reflection.Metadata;
using System.Data;

namespace lms_common
{
    public class Database
    {
        private string _databaseHost = "DESKTOP-TGA2QCA";
        private string _databasePort = "";
        private string _databaseName = "LibraryManagementSystem";

        private string _databaseUsername = "";
        private string _databasePassword = "";

        private SqlConnection _connection;

        public Database(string databaseUsername, string databasePassword)
        {
            _databaseUsername = databaseUsername;
            _databasePassword = databasePassword;

            //string connetionString = $@"Data Source={_databaseHost};Initial Catalog={_databaseName};User ID={_databaseUsername};Password={_databasePassword}";
            string connetionString = "Data Source=DESKTOP-TGA2QCA;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // Data Source=DESKTOP-TGA2QCA;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            _connection = new SqlConnection(connetionString);
            _connection.Open();
        }

        public void InsertInto<T>(T record)
        {
            var fields = typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            string table = "(", values = "(";
            for ( int i = 0; i < fields.Length; i++ )
            {
                table += fields[i].Name;
                if (i != fields.Length - 1) table += ",";


                switch(fields[i].FieldType.Name)
                {
                    case "String": values += $"\'{fields[i].GetValue(record)}\'"; break;
                    default: values += fields[i].GetValue(record); break;
                }

                if (i != fields.Length - 1) values += ",";

            }
            table += ")";
            values += ")";

            string query = $"INSERT INTO {typeof(T).Name}{table} VALUES{values}";

            new SqlCommand(query, _connection).ExecuteNonQuery();
        }

        public List<T> SelectRecords<T>(T record)
        {
            var results = new List<T>();

            var fields = typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Dictionary<string, string> wheres = new Dictionary<string, string>();
            List<string> selects = new List<string>();

            for (int i = 0; i < fields.Length; i++)
            {
                if (fields[i].GetValue(record) == null) selects.Add(fields[i].Name);
                else
                {
                    string value = "";
                    switch (fields[i].FieldType.Name)
                    {
                        case "String": value += $"\'{fields[i].GetValue(record)}\'"; break;
                        default: value += fields[i].GetValue(record); break;
                    }
                    wheres.Add(fields[i].Name, value);
                }
            }

            string query = "SELECT ";
            var selectsArray = selects.ToArray();
            if (selectsArray.Length > 0)
                for (int i = 0; i < selectsArray.Length; i++)
                {
                    query += selectsArray[i];
                    if (i != selectsArray.Length - 1) query += ",";
                    query += " ";
                }
            else query += " * ";

            query += $"FROM {typeof(T).Name} WHERE";

            for (int i = 0; i < wheres.Count; i++)
            {
                var pair = wheres.ElementAt(i);
                query += $" {pair.Key}={pair.Value}";
                if (i != wheres.Count - 1) query += " AND";
            }

            var reader = new SqlCommand(query, _connection).ExecuteReader();

            while(reader.Read())
            {
                T result = record;
                for (int i = 0; i < fields.Length; i++)
                {
                    if (fields[i].GetValue(result) == null) {
                        fields[i].SetValue(result, reader.GetValue(fields[i].Name));
                    }
                }
                results.Add(result);
            }

            return results;
        }

        public void Test()
        {
            foreach (var field in typeof(Model.Book).GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"{field.Name}");
            }

            Console.ReadLine();
        }
    }
}
