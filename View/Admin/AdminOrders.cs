using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ABC_car_traders.View
{
    public partial class AdminOrders : Form
    {
        public AdminOrders()
        {
            InitializeComponent();
            GetCustomer_orderdetails();


        }

        private void updateOrderDetails(object sender, DataGridViewCellEventArgs e)
        {
            
            if (orderDetailGrid.Columns[e.ColumnIndex].Name.ToString() == "onProgress")
            {
                DBManager dbManager = DBManager.GetInstance();
                try
                {
                    dbManager.OpenConnection();
                    int id = Convert.ToInt32(orderDetailGrid.Rows[e.RowIndex].Cells["OrderId"].FormattedValue.ToString());
                    string updateQuery = "UPDATE customerorder SET status = @status WHERE id = @ordId";
                    MySqlCommand cmd = dbManager.GetMysqlCommand(updateQuery);
                    cmd.Parameters.AddWithValue("@status", "ON_PROGRESS");
                    cmd.Parameters.AddWithValue("@ordId", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order No "+id+ " updated to ON_PROGRESS state!");
                    orderDetailGrid.Rows.Clear();
                    dbManager.CloseConnection();
                    GetCustomer_orderdetails();
                }
                catch 
                {

                }
                finally 
                {
                    dbManager.CloseConnection();
                }

            }
            
            if (orderDetailGrid.Columns[e.ColumnIndex].Name == "deleiverd")
            {
                
                DBManager dbManager = DBManager.GetInstance();
                try
                {
                    dbManager.OpenConnection();
                    int id = Convert.ToInt32(orderDetailGrid.Rows[e.RowIndex].Cells["OrderId"].FormattedValue.ToString());
                    string updateQuery = "UPDATE customerorder SET status = @status WHERE id = @ordId";
                    MySqlCommand cmd = dbManager.GetMysqlCommand(updateQuery);
                    cmd.Parameters.AddWithValue("@status", "DELIVERED");
                    cmd.Parameters.AddWithValue("@ordId", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order No " + id + " updated to DELIVERED state!");
                    orderDetailGrid.Rows.Clear();
                    dbManager.CloseConnection();
                    GetCustomer_orderdetails();
                }
                catch
                {

                }
                finally
                {
                    dbManager.CloseConnection();
                }
            }

        }

        public void GetCustomer_orderdetails()
        {
            DBManager dbManager = DBManager.GetInstance();
            try
            {
                dbManager.OpenConnection();
                string innerJoinQuery = "SELECT co.id, co.customer_id, co.total_price, co.created_at, co.status, ur.user_name FROM customerorder co INNER JOIN user ur ON co.customer_id = ur.id;";
                MySqlCommand cmd = dbManager.GetMysqlCommand(innerJoinQuery);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        orderDetailGrid.Rows.Add(dataReader["customer_id"].ToString(),
                                                dataReader["user_name"].ToString(),
                                                dataReader["id"].ToString(),
                                                dataReader["total_price"].ToString(),
                                                dataReader["created_at"].ToString(),
                                                dataReader["status"].ToString());
                    }
                }
                dbManager.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            /*string userType = "CUSTOMER";
            DBManager dbManager = DBManager.GetInstance();
            try
            {
                string query = "SELECT * FROM user WHERE user_type = @userType";
                dbManager.CloseConnection();
                dbManager.OpenConnection();
                MySqlCommand cmd = dbManager.GetMysqlCommand(query);
                cmd.Parameters.AddWithValue("@userType", userType);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        string id = dataReader["id"].ToString();
                        string username = dataReader["user_name"].ToString();
                        string password = dataReader["passwd"].ToString();
                        string firstName = dataReader["first_name"].ToString();
                        string lastName = dataReader["last_name"].ToString();
                        string address = dataReader["address"].ToString();

                        dataGridView1.Rows.Add(id, firstName, lastName, "", "", address, username, password);

                        dataGridView1.AllowUserToAddRows = false;
                    }
                }
                //dbManager.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to fetch user details!: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }*/
        }
    }
}
