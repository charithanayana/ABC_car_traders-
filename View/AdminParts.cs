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

namespace ABC_car_traders.View
{
    public partial class AdminParts : Form
    {
        public AdminParts()
        {
            InitializeComponent();
            loadSparePartDetails();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string name = txtName.Text;
            string description = txtDescription.Text;
            string quantity = txtQuantity.Text;
            string price = txtPrice.Text;

            DBManager dbManager = DBManager.GetInstance();
            try
            {
                string insertQuery = "INSERT INTO sparepart (brand, model, name, description, quantity, price) values(" +
                    "'" + brand + "', " +
                    "'" + model + "', " +
                    "'" + name + "', " +
                    "'" + description + "', " +
                    "'" + quantity + "', " +
                    "'" + price + "'" +
                    ")";
                dbManager.OpenConnection();
                dbManager.Insert(insertQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert spare part details: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
            MessageBox.Show("Registererd Spare Part Succesfully");
        }

        private void loadSparePartDetails()
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

                        dataGridView1.Rows.Add(id, brand, model, name, description, quantity, price);
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
    }
}
