using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


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
            password = "1234";
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

        public MySqlCommand GetMysqlCommand(string query)
        {
            return new MySqlCommand(query, connection);
        }

        public int InsertWithIdentity(string query)
        {
            int insertedId = -1;
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    command.CommandText = "SELECT LAST_INSERT_ID();";
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        insertedId = Convert.ToInt32(result);
                    }
            return insertedId;
        }


    }
}
