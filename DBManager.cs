using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ABC_car_traders
{
    internal class DBManager
    {
        private string server;
        private string database;
        private string username;
        private string password;
        private string connectionString;
        private MySqlConnection connection;

        private static DBManager INSTANCE = null;

        private DBManager()
        {
            server = "localhost";
            database = "abc_car_traders";
            username = "root";
            password = "root";
            connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + username 
                + ";PASSWORD="+ password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public static DBManager GetInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new DBManager();
            }
            return INSTANCE;
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Database error code: " + e.Number);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Database error code: " + e.Number);
                return false;
            }
        }

        public void Insert(String sqlQudery)
        {
            MySqlCommand mCom = new MySqlCommand(sqlQudery, connection);
            mCom.ExecuteNonQuery();
        }

    }
}
