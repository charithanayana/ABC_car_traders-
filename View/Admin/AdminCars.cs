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
                            colour, price, description );
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
