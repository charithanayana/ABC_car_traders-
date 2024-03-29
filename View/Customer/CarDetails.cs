﻿using System;
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
    public partial class CarDetails : Form
    {
        public CarDetails()
        {
            InitializeComponent();
            loadCarDetails();
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
                        string manufactured_year = dataReader["manufactured_year"].ToString();
                        string registered_year = dataReader["registered_year"].ToString();
                        string body_type = dataReader["body_type"].ToString();
                        string engine_capacity = dataReader["engine_capacity"].ToString();
                        string colour = dataReader["colour"].ToString();
                        string price = dataReader["price"].ToString();
                        string transmission = dataReader["transmission"].ToString();
                        string fuel_type = dataReader["fuel_type"].ToString();


                        customerCarGridView1.Rows.Add(brand, model, manufactured_year, registered_year,
                            body_type, engine_capacity, colour, price, transmission, fuel_type
                             );
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
            string searchkey = txtCarSearchKey.Text;
            if (searchkey ==null || searchkey == "" )
            {
                MessageBox.Show("Please enter model to search");
                return;
            }
            customerCarGridView1.Rows.Clear();
            loadCarDetails(searchkey);
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
                    customerCarGridView1.Rows.Add(id, model, description, unitPrice, "CAR");
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
    }
}
