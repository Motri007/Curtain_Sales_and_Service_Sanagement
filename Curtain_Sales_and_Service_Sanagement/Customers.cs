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

    public partial class Customers : Form
    {
        
        public Menu menu;
        public Customers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string FName = txtFName.Text;
                string LName = txtLName.Text;
                string NCod = txtNCod.Text;
                string Telephone = txtTelephone.Text;
                string Mobile = txtMobile.Text;
                string Email = txtEmail.Text;
                string PostalCod =txtPostalCod.Text;
                string Address = txtAddress.Text;
                
                if (FName == "" || LName == ""|| NCod == "" || Telephone == ""|| Mobile == ""||Email==""||PostalCod==""||Address=="")
                {
                    MessageBox.Show("! اطلاعات را کامل وارد کنین", "!توجه");
                }
                else
                {
                    cmd1.Connection = sc1;
                    cmd1.Parameters.Clear();
                    sc1.Open();
                    string query = "INSERT INTO Customers (FName,LName,NCod,Telephone,Mobile,Email,Address,PostalCod)" +
                        "VALUES(N'" + FName + "',N'" + LName + "',N'" + NCod + "',N'" + Telephone + "',N'" + Mobile + "',N'" + Email + "',N'" + PostalCod + "',N'" + Address + "')";
                    cmd1 = new SqlCommand(query, sc1);
                    cmd1.ExecuteNonQuery();
                    sc1.Close();

                    Display();

                    MessageBox.Show("مشتری یا موففیت ثبت شد");
                    txtFName.Text = txtLName.Text = txtNCod.Text = txtTelephone.Text = txtMobile.Text = txtEmail.Text =  txtPostalCod.Text =txtAddress.Text = "";
                }
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
            this.Hide();
            e.Cancel = true;
        }

        SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\Curtain_Sales_and_Service_Sanagement\\Curtain_Sales_and_Service_Sanagement\\Database1.mdf;Integrated Security=True");
        SqlConnection sc1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\Curtain_Sales_and_Service_Sanagement\\Curtain_Sales_and_Service_Sanagement\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();

        void Display()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = sc;
            adp.SelectCommand.CommandText = "SELECT * FROM Customers";
            adp.Fill(ds, "Customers");
            dgvCustomers.DataSource = ds;
            dgvCustomers.DataMember = "Customers";

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            Display();
            dgvCustomers.Columns[0].HeaderText = "کد مشتری";
            dgvCustomers.Columns[1].HeaderText = "نام";
            dgvCustomers.Columns[2].HeaderText = "نام خانوادگی";
            dgvCustomers.Columns[3].HeaderText = "کد ملی";
            dgvCustomers.Columns[4].HeaderText = "تلفن ثابت";
            dgvCustomers.Columns[5].HeaderText = "شماره موبایل";
            dgvCustomers.Columns[6].HeaderText = "ایمیل";
            dgvCustomers.Columns[7].HeaderText = "کد پستی";
            dgvCustomers.Columns[8].HeaderText = "آدرس";
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = sc;
            adp.SelectCommand.CommandText = "SELECT * FROM Customers WHERE FName LIKE '%'+@S+'%' ";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtFilterName.Text + "%");
            adp.Fill(ds, "Customers");
            dgvCustomers.DataSource = ds;
            dgvCustomers.DataMember = "Customers";

        }
        private void txtFilterMobile_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = sc;
            adp.SelectCommand.CommandText = "SELECT * FROM Customers WHERE Mobile LIKE '%'+@S+'%' ";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtFilterMobile.Text + "%");
            adp.Fill(ds, "Customers");
            dgvCustomers.DataSource = ds;
            dgvCustomers.DataMember = "Customers";
        }

        private void dgvCustomers_MouseUp(object sender, MouseEventArgs e)
        {
            txtIdCustomers.Text = dgvCustomers[0,dgvCustomers.CurrentRow.Index].Value.ToString();
            txtFName.Text = dgvCustomers[1,dgvCustomers.CurrentRow.Index].Value.ToString();
            txtLName.Text = dgvCustomers[2,dgvCustomers.CurrentRow.Index].Value.ToString();
            txtNCod.Text = dgvCustomers[3,dgvCustomers.CurrentRow.Index].Value.ToString();
            txtTelephone.Text = dgvCustomers[4,dgvCustomers.CurrentRow.Index].Value.ToString();
            txtMobile.Text = dgvCustomers[5,dgvCustomers.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvCustomers[6,dgvCustomers.CurrentRow.Index].Value.ToString();
            txtPostalCod.Text = dgvCustomers[7,dgvCustomers.CurrentRow.Index].Value.ToString();
            txtAddress.Text = dgvCustomers[8,dgvCustomers.CurrentRow.Index].Value.ToString();
            if(txtIdCustomers.Text=="")
                btnRecord.Enabled= true;
            else
                btnRecord.Enabled= false;
            if (txtIdCustomers.Text != "")
                btnEdit.Enabled = true;
            else
                btnEdit.Enabled = false;
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string IDCustomer = txtIdCustomers.Text;
                string FName = txtFName.Text;
                string LName = txtLName.Text;
                string NCod = txtNCod.Text;
                string Telephone = txtTelephone.Text;
                string Mobile = txtMobile.Text;
                string Email = txtEmail.Text;
                string PostalCod = txtPostalCod.Text;
                string Address = txtAddress.Text;
                if (FName == "" || LName == "" || NCod == "" || Telephone == "" || Mobile == "" || Email == "" || PostalCod == "" || Address == "" )
                {
                    MessageBox.Show("کد مشتری مورد نظر را انتخاب کنین");
                }
                else
                {
                    int x = Convert.ToInt32(dgvCustomers.SelectedCells[0].Value);
                    cmd.Connection = sc;
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE Customers SET FName = N'" + FName + "',LName = N'" + LName + "' ,NCod= N'" + NCod + "',Telephone= N'" + Telephone + "',Mobile= N'" + Mobile + "',Email= N'" + Email + "',PostalCod= N'" + PostalCod + "',Address= N'" + Address + "' WHERE  IdCustomers = @N ";
                    cmd.Parameters.AddWithValue("@N", x);
                    sc.Open();
                    cmd.ExecuteNonQuery();
                    sc.Close();

                    Display();
                    MessageBox.Show("مشتری یا موففیت ویرایش شد");
                    txtIdCustomers.Text = txtFName.Text = txtLName.Text = txtNCod.Text = txtTelephone.Text = txtMobile.Text = txtEmail.Text = txtPostalCod.Text = txtAddress.Text = "";
                    btnRecord.Enabled= true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
