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
                txtBrand.Clear();
                txtModel.Clear();
                txtName.Clear();
                txtDescription.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
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
            sparePartDataGrid.Rows.Clear();
            loadSparePartDetails();
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

                        sparePartDataGrid.Rows.Add(id, brand, model, name, description, quantity, price);
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

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            DBManager dbManager = DBManager.GetInstance();
            try
            {
                for (int item = 0; item < sparePartDataGrid.Rows.Count; item++)
                {
                    string updateQuery = "UPDATE sparepart SET brand = @brand, model = @model, name = @name, description = @description, quantity = @quantity, price = @price WHERE id = @sparepartId";
                    dbManager.OpenConnection();
                    MySqlCommand cmd = dbManager.GetMysqlCommand(updateQuery);
                    cmd.Parameters.AddWithValue("@brand", sparePartDataGrid.Rows[item].Cells[1].Value);//brand
                    cmd.Parameters.AddWithValue("@model", sparePartDataGrid.Rows[item].Cells[2].Value);//model
                    cmd.Parameters.AddWithValue("@name", sparePartDataGrid.Rows[item].Cells[3].Value);//name
                    cmd.Parameters.AddWithValue("@description", sparePartDataGrid.Rows[item].Cells[4].Value);//description
                    cmd.Parameters.AddWithValue("@quantity", sparePartDataGrid.Rows[item].Cells[5].Value);//quantity
                    cmd.Parameters.AddWithValue("@price", sparePartDataGrid.Rows[item].Cells[6].Value);//price
                    cmd.Parameters.AddWithValue("@sparepartId", sparePartDataGrid.Rows[item].Cells[0].Value);//id
                    cmd.ExecuteNonQuery();
                    dbManager.CloseConnection();
                }
                MessageBox.Show("Row has been updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to udpate user details: " + ex.Message);
            }
            finally { }
        }

        private void btnDelete(object sender, DataGridViewCellEventArgs e)
        {
            DBManager dbManager = DBManager.GetInstance();
            try
            {
                if (sparePartDataGrid.Columns[e.ColumnIndex].Name == "action")
                {
                    if (MessageBox.Show("Are you sure to delete?", "Delete Record!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM sparepart WHERE id = @sparepartId";
                        dbManager.OpenConnection();
                        int id = Convert.ToInt32(sparePartDataGrid.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                        MySqlCommand cmd = dbManager.GetMysqlCommand(deleteQuery);
                        cmd.Parameters.AddWithValue("@sparepartId", id);
                        cmd.ExecuteNonQuery();
                        dbManager.CloseConnection();
                        sparePartDataGrid.Rows.Clear();
                        loadSparePartDetails();
                        MessageBox.Show("Record has been deleted!");
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dbManager.CloseConnection();
            }
        }
    }
}
