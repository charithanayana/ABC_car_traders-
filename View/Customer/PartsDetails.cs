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
    public partial class PartsDetails : Form
    {
        public PartsDetails()
        {
            InitializeComponent();
            loadCarDetails();
        }

        private void loadCarDetails()
        {
            DBManager dbManager = DBManager.GetInstance();
            try
            {
                string query = "SELECT * FROM sparepart";
                dbManager.OpenConnection();
                MySqlCommand cmd = dbManager.GetMysqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        string id = dataReader["id"].ToString();
                        string brand = dataReader["brand"].ToString();
                        string model = dataReader["model"].ToString();
                        string name = dataReader["name"].ToString();
                        string description = dataReader["description"].ToString();
                        string quantity = dataReader["quantity"].ToString();
                        string price = dataReader["price"].ToString();



                        customPartsGridView1.Rows.Add(brand, model, name, description, quantity, price);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get car details: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchkey = txtSearchPartsKey.Text;
            if (searchkey == null || searchkey == "")
            {
                MessageBox.Show("Please enter model to search");
                return;
            }
            customPartsGridView1.Rows.Clear();
            loadSparePartDetails(searchkey);
        }

        private void loadSparePartDetails(string searchkey)
        {
            DBManager dbManager = DBManager.GetInstance();
            MySqlDataReader dataReader = null;
            try
            {
                string query = "SELECT * FROM sparepart WHERE model like '%" + searchkey + "%'";
                dbManager.OpenConnection();
                MySqlCommand cmd = dbManager.GetMysqlCommand(query);
                dataReader = cmd.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    return;
                }

                while (dataReader.Read())
                {
                    string id = dataReader["id"].ToString();
                    string brand = dataReader["brand"].ToString();
                    string model = dataReader["model"].ToString();
                    string name = dataReader["name"].ToString();
                    string description = dataReader["description"].ToString();
                    string quantity = dataReader["quantity"].ToString();
                    string price = dataReader["price"].ToString();



                    customPartsGridView1.Rows.Add(brand, model, name, description, quantity, price);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get parts details: " + ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                dbManager.CloseConnection();
            }
        }
    }
}
