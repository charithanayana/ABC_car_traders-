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
    public partial class AdmiCoustomer : Form
    {
        public AdmiCoustomer()
        {
            InitializeComponent();
            GetCustomerDetail();
        }

        private void update_button(object sender, EventArgs e)
        {
            DBManager dbManager = DBManager.GetInstance();
            for (int item = 0; item<dataGridView1.Rows.Count; item++)
            {
                string updateQuery = "UPDATE user SET user_name = @userName, passwd = @password, first_name = @firstName, last_name = @lastName, address = @address WHERE id = @userId";
                dbManager.OpenConnection();
                MySqlCommand cmd = dbManager.GetMysqlCommand(updateQuery);
                cmd.Parameters.AddWithValue("@firstName", dataGridView1.Rows[item].Cells[1].Value);//first name
                cmd.Parameters.AddWithValue("@lastName", dataGridView1.Rows[item].Cells[2].Value);//last name
                //cmd.Parameters.AddWithValue("@userName", dataGridView1.Rows[item].Cells[3].Value);//mobile
                //cmd.Parameters.AddWithValue("@userName", dataGridView1.Rows[item].Cells[4].Value);//email
                cmd.Parameters.AddWithValue("@address", dataGridView1.Rows[item].Cells[5].Value);//address
                cmd.Parameters.AddWithValue("@userName", dataGridView1.Rows[item].Cells[6].Value);//username
                cmd.Parameters.AddWithValue("@password", dataGridView1.Rows[item].Cells[7].Value);//password
                cmd.Parameters.AddWithValue("@userId", dataGridView1.Rows[item].Cells[0].Value);//id
                cmd.ExecuteNonQuery();
                dbManager.CloseConnection();
                MessageBox.Show("Row has been updated!");
            }
        }

        private void GetCustomerDetail()
        {
            string userType = "CUSTOMER";
            //dataGridView1.Rows.Add("Sachintha");
            DBManager dbManager = DBManager.GetInstance();
            try
            {
                string query = "SELECT * FROM user WHERE user_type = @userType";
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
                dbManager.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert user details: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
