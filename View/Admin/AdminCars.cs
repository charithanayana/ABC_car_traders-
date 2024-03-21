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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ABC_car_traders.View
{
    public partial class AdminCars : Form
    {
        public AdminCars()
        {
            InitializeComponent();
            loadCarDetails();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string manufacturedYear = txtManufactureYear.Text;
            string registeredYear = txtRegisteredYear.Text;
            string bodyType = txtBodyType.Text;
            string engineCapacity = txtEngineCapacity.Text;
            string colour = txtColour.Text;
            string price = txtPrice.Text;
            string transmission = cmbTransmission.Text;
            string fuelType = cmbFuelType.Text;
            string description = txtDescription.Text;

            DBManager dbManager = DBManager.GetInstance();
            try
            {
                string insertQuery = "INSERT INTO car (brand, model, manufactured_year, registered_year, body_type, engine_capacity, colour, price, transmission, fuel_type, description) values(" +
                    "'" + brand + "', " +
                    "'" + model + "', " +
                    "'" + manufacturedYear + "', " +
                    "'" + registeredYear + "', " +
                    "'" + bodyType + "', " +
                    "'" + engineCapacity + "', " +
                    "'" + colour + "', " +
                    "'" + price + "', " +
                    "'" + transmission + "', " +
                    "'" + fuelType + "', " +
                    "'" + description + "'" +
                    ")";
                dbManager.OpenConnection();
                dbManager.Insert(insertQuery);
                txtBrand.Clear();
                txtModel.Clear();
                txtManufactureYear.Clear();
                txtRegisteredYear.Clear();
                txtBodyType.Clear();
                txtEngineCapacity.Clear();
                txtColour.Clear();
                txtPrice.Clear();
                txtDescription.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert car details: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
            MessageBox.Show("Registererd Car Succesfully");
            gridCarDetails.Rows.Clear();
            loadCarDetails();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }



        private void loadCarDetails()
        {
            DBManager dbManager = DBManager.GetInstance();
            try
            {
                string query = "SELECT * FROM car";
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
                        string body_type = dataReader["body_type"].ToString();
                        string manufactured_year = dataReader["manufactured_year"].ToString();
                        string engine_capacity = dataReader["engine_capacity"].ToString();
                        string transmission = dataReader["transmission"].ToString();
                        string fuel_type = dataReader["fuel_type"].ToString();
                        string colour = dataReader["colour"].ToString();
                        string price = dataReader["price"].ToString();
                        string description = dataReader["description"].ToString();

                        gridCarDetails.Rows.Add(id, brand, model, body_type, manufactured_year, engine_capacity, transmission, fuel_type,
                            colour, price, description);
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

        private void button1_Click(object sender, EventArgs e)
        {
            DBManager dBManager = DBManager.GetInstance();
            try
            {
                for (int item = 0; item < gridCarDetails.Rows.Count; item++)
                {
                    string updateQuery = "UPDATE car SET brand = @brand, model = @model, manufactured_year = @manufactured_year,  body_type = @body_type, engine_capacity = @engine_capacity, colour =@colour,  price = @price, transmission = @transmission, fuel_type = @fuel_type, description = @description WHERE id = @carId";
                    dBManager.OpenConnection();
                    MySqlCommand cmd = dBManager.GetMysqlCommand(updateQuery);
                    cmd.Parameters.AddWithValue("@carId", gridCarDetails.Rows[item].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@brand", gridCarDetails.Rows[item].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@model", gridCarDetails.Rows[item].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@body_type", gridCarDetails.Rows[item].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@manufactured_year", gridCarDetails.Rows[item].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@engine_capacity", gridCarDetails.Rows[item].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@transmission", gridCarDetails.Rows[item].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@fuel_type", gridCarDetails.Rows[item].Cells[7].Value);
                    cmd.Parameters.AddWithValue("@colour", gridCarDetails.Rows[item].Cells[8].Value);
                    cmd.Parameters.AddWithValue("@price", gridCarDetails.Rows[item].Cells[9].Value);
                    cmd.Parameters.AddWithValue("@description", gridCarDetails.Rows[item].Cells[10].Value);


                    cmd.ExecuteNonQuery();
                    dBManager.CloseConnection();
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
            DBManager dBManager = DBManager.GetInstance();
            try
            {
                if (gridCarDetails.Columns[e.ColumnIndex].Name == "delete")
                {
                    if (MessageBox.Show("Are you sure to delete?", "Delete Record!", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                    {
                        
                        string deleteQuery = "DELETE FROM car WHERE id = @carId";
                        dBManager.OpenConnection();
                        int id = Convert.ToInt32(gridCarDetails.Rows[e.RowIndex].Cells["CarID"].FormattedValue.ToString());
                        MessageBox.Show(id.ToString());
                        MySqlCommand cmd = dBManager.GetMysqlCommand(deleteQuery);
                        cmd.Parameters.AddWithValue("@carId", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been deleted!");
                        gridCarDetails.Rows.Clear();
                        dBManager.CloseConnection();
                        loadCarDetails();
                        
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally 
            {
                dBManager.CloseConnection();
            }
        }
    }
}
