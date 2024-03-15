using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            LoadDefaultForm();

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        public void LoadDefaultForm()
        {
            loadform(new AdminDashboard());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadform(new AdminDashboard());
        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            loadform(new AdmiCoustomer());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            loadform(new AdminReports());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            loadform(new AdminCars());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            loadform(new AdminParts());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            loadform(new AdminOrders());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadform(new AdminDashboard());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadform(new AdmiCoustomer());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadform(new AdminReports());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loadform(new AdminCars());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            loadform(new AdminParts());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loadform(new AdminOrders());
        }
    }
}
