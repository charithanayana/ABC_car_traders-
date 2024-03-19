using ABC_car_traders.View;
using MySql.Data.MySqlClient;

namespace ABC_car_traders
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string tmpPassword = null;
            string tmpUserType = null;
            int userId = -1;

            DBManager dbManager = DBManager.GetInstance();
            try
            {
                string query = "SELECT * FROM user WHERE user_name = @userName";
                dbManager.OpenConnection();
                MySqlCommand cmd = dbManager.GetMysqlCommand(query);
                cmd.Parameters.AddWithValue("@userName", userName);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        tmpPassword = dataReader["passwd"].ToString();
                        tmpUserType = dataReader["user_type"].ToString();
                        userId = int.Parse(dataReader["id"].ToString());
                    }
                    if (!password.Equals(tmpPassword))
                    {
                        MessageBox.Show("Authentication failed");
                    }
                    else
                    {
                        dbManager.CloseConnection();
                        this.Hide();
                        /*methanata*/
                        UserClass.UserId = userId;
                        if ("CUSTOMER".Equals(tmpUserType))
                        {
                            new CustomerDashboard().ShowDialog(this);
                        }
                        else if ("ADMIN".Equals(tmpUserType))
                        {
                            new Admin().ShowDialog(this);
                        }
                        else
                        {
                            MessageBox.Show("No valid user type found");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No user found for the given user name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get user details: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Register().ShowDialog(this);
        }
    }
}
