using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curtain_Sales_and_Service_Sanagement
{
    public partial class Menu : Form
    {
        Customers customers = new Customers();
        Warehouse warehouse = new Warehouse();
        Factor factor = new Factor();

        public Menu()
        {
            InitializeComponent();
            customers.menu = this;
            warehouse.menu = this;
            factor.menu = this;

        }
        string x;
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string exit = Exit(x);
            e.Cancel = true;
        }
        public string Exit (string x)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("آیا می خواهید خارج شوید؟", "خروج از برنامه", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Application.ExitThread();
            return x;
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customers.Show();
            this.Hide();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            warehouse.Show();
            this.Hide();
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            factor.Show();
            this.Hide();
        }
    }
}