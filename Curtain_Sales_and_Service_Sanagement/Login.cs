using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curtain_Sales_and_Service_Sanagement
{
    public partial class Login : Form
    {
        Menu menu = new Menu();
        public Login()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUser.Text;
                string pass = txtPass.Text;
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\Curtain_Sales_and_Service_Sanagement\\Curtain_Sales_and_Service_Sanagement\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, sc);
                SqlDataReader reader = cmd.ExecuteReader();
                if (user == "" || pass == "")
                {
                    MessageBox.Show("اطلاعات را کامل وارد کنین", "Error");
                }
                else
                {
                    while (reader.Read())
                    {
                        string username = reader["Username"].ToString();
                        string password = reader["Password"].ToString();
                        if (pass == password)
                        {
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("...یوزرنیم یا پسوورد اشتباه است");
                        }
                    }
                }

                sc.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
