using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABC_car_traders.View
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchkey = txtSearchKey.Text;
            if (searchkey == null || searchkey == "")
            {
                MessageBox.Show("Please enter model to search");
                return;
            }
            dataGridSearch.Rows.Clear();
            loadCarDetails(searchkey);
            loadSparePartDetails(searchkey);
        }

        private void loadCarDetails(string searchkey)
        {
            DBManager dbManager = DBManager.GetInstance();
            MySqlDataReader dataReader = null;
            try
            {
                string query = "SELECT * FROM car WHERE model like '%" + searchkey + "%'";
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
                    string model = dataReader["model"].ToString();
                    string description = dataReader["description"].ToString();
                    string unitPrice = dataReader["price"].ToString();
                    dataGridSearch.Rows.Add(id, model, description, unitPrice, "CAR");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get car details: " + ex.Message);
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
                    string model = dataReader["model"].ToString();
                    string description = dataReader["description"].ToString();
                    string unitPrice = dataReader["price"].ToString();
                    dataGridSearch.Rows.Add(id, model, description, unitPrice, "SPAREPART");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get car details: " + ex.Message);
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

        private void clickAddToCart(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridSearch.Columns[e.ColumnIndex].Name == "Action")
            {
                string id = dataGridSearch.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                string model = dataGridSearch.Rows[e.RowIndex].Cells["Model"].FormattedValue.ToString();
                string description = dataGridSearch.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                string unitPrice = dataGridSearch.Rows[e.RowIndex].Cells["UnitPrice"].FormattedValue.ToString();
                string type = dataGridSearch.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
                int quantity = 1;
                double price = quantity * Convert.ToInt32(unitPrice);
                dataGridOrder.Rows.Add(id, model, description, unitPrice, type, quantity, price);
                double total = getTotalPrice();
                lblTotalPrice.Text = total.ToString();
            }
        }

        private double getTotalPrice()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridOrder.Rows)
            {
                if (row.Cells["Price"] != null && row.Cells["Price"].Value != null)
                {
                    string priceString = row.Cells["Price"].Value.ToString();
                    total += Double.Parse(priceString);
                }
            }
            return total;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridOrder.Rows)
            {
                if (row.Cells["Price"] != null && row.Cells["Price"].Value != null)
                {
                    string priceString = row.Cells["Price"].Value.ToString();
                    total += Double.Parse(priceString);
                }
            }
        }
    }
}
