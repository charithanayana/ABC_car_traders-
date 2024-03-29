﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_car_traders.View
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstNname = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string userName = txtUserName.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            DBManager dbManager = DBManager.GetInstance();
            try
            {
                if (password.Equals(confirmPassword))
                {
                    string insertQuery = "INSERT INTO user (user_name, passwd, user_type, first_name, last_name, address) values('"
                        + userName + "', '" + password + "', 'CUSTOMER', '" + firstNname + "', '" + lastName + "', '" + address + "')";
                    dbManager.OpenConnection();
                    dbManager.Insert(insertQuery);
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtAddress.Clear();
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Confirm Password incorrect");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert user details: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
            MessageBox.Show("Register Succesfully");
        }


        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
