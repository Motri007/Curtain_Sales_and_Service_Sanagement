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
    public partial class Factor : Form
    {
        public Menu menu;

        public Factor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void Factor_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
            this.Hide();
            e.Cancel = true;
        }
    }
}
