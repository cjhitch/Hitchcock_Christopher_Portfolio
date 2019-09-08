using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace hitchcock_christopher_dbsreview
{
    public class Utility
    {
        static Utility instance = new Utility();
        private MySqlConnection _conn = null;
        public static void StartConnection()
        {
            
            instance._conn = new MySqlConnection();
            
            instance.Connect();
        }
        private void Connect()
        {
            BuildConnString();
            try
            {
                _conn.Open();
            }
            catch (MySqlException e)
            {
                string msg = "";
                switch (e.Number)
                {
                    case 0:
                    {
                        msg = e.ToString();
                    }
                        break;
                    case 1042:
                    {
                        msg = "Can't resolve host address. \r\n " + _conn.ConnectionString;
                    }
                        break;
                    case 1045:
                    {
                        msg = "Invalid username/password";
                    }
                        break;
                    default:
                    {
                        msg = e.ToString();
                    }
                        break;
                }
                Console.WriteLine(msg);
            }
        }

        private void BuildConnString()
        {
            string connString = $"Server=localhost;";
            connString += "uid=dbsAdmin;";
            connString += "pwd=password;";
            connString += "database=weather;";
            connString += "port=8889;";

            _conn.ConnectionString = connString;
        }

        public static MySqlConnection Conn
        {
            get
            {
                return instance._conn;
            }
        } 
    }
}