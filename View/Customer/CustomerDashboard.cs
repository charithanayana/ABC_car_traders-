using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_car_traders.View.Customer;

namespace ABC_car_traders.View
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();

            LoadDefaultForm();
        }

        public void loadform(object Form)
        {
            if (this.OrderDetails.Controls.Count > 0)
                this.OrderDetails.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.OrderDetails.Controls.Add(f);
            this.OrderDetails.Tag = f;
            f.Show();
        }

        public void LoadDefaultForm()
        {
            loadform(new CustomerHome());
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadform(new CarDetails());
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            loadform(new OrderDetails());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadform(new CustomerHome());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadform(new CustomerHome());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loadform(new OrderDetails());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loadform(new CarDetails());
        }
    }
}
