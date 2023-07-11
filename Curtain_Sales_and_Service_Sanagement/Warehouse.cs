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
    public partial class Warehouse : Form
    {
        public Menu menu;
        public Warehouse()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            Display();
            dgvWarehouse.Columns[0].HeaderText = "کد کالا";
            dgvWarehouse.Columns[1].HeaderText = "نام کالای";
            dgvWarehouse.Columns[2].HeaderText = "قیمت";
            dgvWarehouse.Columns[3].HeaderText = "موجودی";
            dgvWarehouse.Columns[4].HeaderText = "تعداد فروش";
            dgvWarehouse.Columns[5].HeaderText = "نوع";
            dgvWarehouse.Columns[6].HeaderText = "اندازه";
            dgvWarehouse.Columns[7].HeaderText = "رنگ";
        }
        void Display()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = sc;
            adp.SelectCommand.CommandText = "SELECT * FROM Warehouse";
            adp.Fill(ds, "Warehouse");
            dgvWarehouse.DataSource = ds;
            dgvWarehouse.DataMember = "Warehouse";

        }

        SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\Curtain_Sales_and_Service_Sanagement\\Curtain_Sales_and_Service_Sanagement\\Database1.mdf;Integrated Security=True");
        SqlConnection sc1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\Curtain_Sales_and_Service_Sanagement\\Curtain_Sales_and_Service_Sanagement\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();

        private void btnCommodity_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = cmbName.Text;
                string Price = txtPrice.Text;
                string Number = txtNumber.Text;
                string Type = cmbType.Text;
                string Size = txtSize.Text;
                string Color = cmbColor.Text;

                if (Name == "" || Price == "" || Number == "")
                {
                    MessageBox.Show("! اطلاعات را کامل وارد کنین", "!توجه");
                }
                else
                {
                    cmd.Connection = sc;
                    cmd.Parameters.Clear();
                    sc.Open();
                    string query = "INSERT INTO Warehouse (Name,Price,Stock,Type,Size,Color)" +
                        "VALUES(N'" + Name + "',N'" + Price + "',N'" + Number + "',N'" + Type + "',N'" + Size + "',N'" + Color + "')";
                    cmd = new SqlCommand(query, sc);
                    cmd.ExecuteNonQuery();
                    sc.Close();

                    Display();

                    MessageBox.Show("کالا یا موففیت ثبت شد");
                    cmbName.Text = txtPrice.Text = txtNumber.Text = cmbType.Text = txtSize.Text = cmbColor.Text = "";
                }
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Warehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
            this.Hide();
            e.Cancel = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void btnEditPrice_Click(object sender, EventArgs e)
        {
            try
            {
                string EditPrice = txtEditPrice.Text;
                
                if (txtEditPrice.Text == "")
                {
                    MessageBox.Show("قیمت کالا مورد نظر را انتخاب کنین");
                }
                else
                {
                    int x = Convert.ToInt32(dgvWarehouse.SelectedCells[3].Value);
                    cmd1.Connection = sc1;
                    cmd1.Parameters.Clear();
                    cmd1.CommandText = "UPDATE Warehouse SET FName = N'" + EditPrice + "' WHERE  Price = @N ";
                    cmd1.Parameters.AddWithValue("@N", x);
                    sc1.Open();
                    cmd1.ExecuteNonQuery();
                    sc1.Close();

                    Display();
                    MessageBox.Show("قیمت یا ویرایش شد");

                    btnEditPrice.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvWarehouse_MouseUp(object sender, MouseEventArgs e)
        {
            txtEditPrice.Text = dgvWarehouse[3, dgvWarehouse.CurrentRow.Index].Value.ToString();
            if (txtEditPrice.Text != "")
            {
                txtEditPrice.Enabled = true;
            }
            else
            {
                txtEditPrice.Enabled = false;
            }
        }

        private void txtFilterNameC_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = sc;
            adp.SelectCommand.CommandText = "SELECT * FROM Warehouse WHERE Name LIKE '%'+@S+'%' ";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtFilterNameC.Text + "%");
            adp.Fill(ds, "Warehouse");
            dgvWarehouse.DataSource = ds;
            dgvWarehouse.DataMember = "Warehouse";
        }

        private void txtFilterType_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = sc;
            adp.SelectCommand.CommandText = "SELECT * FROM Warehouse WHERE Type LIKE '%'+@S+'%' ";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtFilterType.Text + "%");
            adp.Fill(ds, "Warehouse");
            dgvWarehouse.DataSource = ds;
            dgvWarehouse.DataMember = "Warehouse";
        }
    }
}

