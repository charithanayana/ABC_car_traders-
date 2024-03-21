using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABC_car_traders.View.Customer
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
            GetCustomer_orderdetails();
           
        }

        private void GetCustomer_orderdetails()
        {
            DBManager dBManager = DBManager.GetInstance();
            try
            {
                dBManager.OpenConnection();
                string innerJoinQuery = "SELECT co.id, co.customer_id, co.total_price, co.created_at, co.status, ur.user_name FROM customerorder co INNER JOIN user ur ON co.customer_id = ur.id where co.customer_id = @UserId;";
                MySqlCommand cmd = dBManager.GetMysqlCommand(innerJoinQuery);
                cmd.Parameters.AddWithValue("@UserId", UserClass.UserId);
                MySqlDataReader datareader = cmd.ExecuteReader();
                
                if (datareader.HasRows)
                {
                    while(datareader.Read())
                    {
                        custOrderViewGridView1.Rows.Add(datareader["id"].ToString(),
                                                        datareader["total_price"].ToString(),
                                                        datareader["created_at"].ToString(),
                                                        datareader["status"].ToString());
                    }
                }
                dBManager.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {

            }
        }

    }
}
