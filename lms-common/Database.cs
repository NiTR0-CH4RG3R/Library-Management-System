using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using System.Reflection.Metadata;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Win32;

namespace lms_common
{
    [AttributeUsage(AttributeTargets.Field)]
    public class PrimaryKey : Attribute
    {

    }

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

        static string GetValueStringAccordingToType( string typename, Object? value )
        {
            if (value == null) return "NULL";
            string result = "";
            switch (typename)
            {
                case null: break;
                case "String": result = $"\'{value}\'" ; break;
                case "DateTime": result = $"\'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}\'"; break;
                case "Boolean": result = (bool)value ? "1" : "0"; break;
                default: result = value == null ? "" : value.ToString(); break;
            }
            return result;
        }

        public void InsertInto<T>(T record)
        {
            var fields = typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            string table = "(", values = "(";
            for ( int i = 0; i < fields.Length; i++ )
            {
                table += fields[i].Name;
                if (i != fields.Length - 1) table += ",";
                Type type = Nullable.GetUnderlyingType(fields[i].FieldType) ?? fields[i].FieldType;
                values += GetValueStringAccordingToType(type.Name, fields[i].GetValue(record));

                if (i != fields.Length - 1) values += ",";

            }
            table += ")";
            values += ")";

            string query = $"INSERT INTO [{typeof(T).Name}]{table} VALUES{values}";

            new SqlCommand(query, _connection).ExecuteNonQuery();
        }

        public List<T> SelectFrom<T>(T record) where T : new()
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
                    Type type = Nullable.GetUnderlyingType(fields[i].FieldType) ?? fields[i].FieldType;
                    string value = GetValueStringAccordingToType(type.Name, fields[i].GetValue(record));
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

            query += $"FROM [{typeof(T).Name}]";

            if (wheres.Count > 0)
            {
                query += " WHERE";
                for (int i = 0; i < wheres.Count; i++)
                {
                    var pair = wheres.ElementAt(i);
                    query += $" {pair.Key}={pair.Value}";
                    if (i != wheres.Count - 1) query += " AND";
                }
            }

            var reader = new SqlCommand(query, _connection).ExecuteReader();

            while(reader.Read())
            {
                T result = new T();
                for (int i = 0; i < fields.Length; i++)
                {
                    if (fields[i].GetValue(record) == null) {
                        //var t = typeof(reader.GetValue(fields[i].Name));
                        fields[i].SetValue(result, reader.IsDBNull(fields[i].Name) ? null : reader.GetValue(fields[i].Name));
                    } else
                    {
                        fields[i].SetValue(result, fields[i].GetValue(record));
                    }
                }
                results.Add(result);
            }

            reader.Close();

            return results;
        }

        public void DeleteFrom<T>(T record)
        {
            var fields = typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Dictionary<string, string> wheres = new Dictionary<string, string>();

            for (int i = 0; i < fields.Length; i++)
            {
                if (fields[i].GetValue(record) != null)
                {
                    Type type = Nullable.GetUnderlyingType(fields[i].FieldType) ?? fields[i].FieldType;
                    string value = GetValueStringAccordingToType(type.Name, fields[i].GetValue(record));
                    wheres.Add(fields[i].Name, value);
                }
            }

            string query = $"DELETE FROM [{typeof(T).Name}] WHERE";

            for (int i = 0; i < wheres.Count; i++)
            {
                var pair = wheres.ElementAt(i);
                query += $" {pair.Key}={pair.Value}";
                if (i != wheres.Count - 1) query += " AND";
            }

            new SqlCommand(query, _connection).ExecuteNonQuery();
        }

        public void UpdateByPrimaryKey<T>(T record)
        {
            var fields = typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Dictionary<string, string> wheres = new Dictionary<string, string>();
            Dictionary<string, string> sets = new Dictionary<string, string>();

            for (int i = 0; i < fields.Length; i++)
            {
                if (fields[i].GetValue(record) != null)
                {
                    if (fields[i].GetCustomAttribute(typeof(PrimaryKey), false) == null)
                    {
                        Type type = Nullable.GetUnderlyingType(fields[i].FieldType) ?? fields[i].FieldType;
                        sets.Add(fields[i].Name, GetValueStringAccordingToType(type.Name, fields[i].GetValue(record)));
                    }
                    else if (fields[i].GetCustomAttribute(typeof(PrimaryKey), false) != null)
                    {
                        Type type = Nullable.GetUnderlyingType(fields[i].FieldType) ?? fields[i].FieldType;
                        wheres.Add(fields[i].Name, GetValueStringAccordingToType(type.Name, fields[i].GetValue(record)));
                    }
                }
            }

            string query = $"UPDATE [{typeof(T).Name}] SET";

            for (int i = 0; i < sets.Count; i++)
            {
                var pair = sets.ElementAt(i);
                query += $" {pair.Key}={pair.Value}";
                if (i != wheres.Count - 1) query += ",";
            }

            query += " WHERE";
            for (int i = 0; i < wheres.Count; i++)
            {
                var pair = wheres.ElementAt(i);
                query += $" {pair.Key}={pair.Value}";
                if (i != wheres.Count - 1) query += " AND";
            }

            new SqlCommand(query, _connection).ExecuteNonQuery();
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
