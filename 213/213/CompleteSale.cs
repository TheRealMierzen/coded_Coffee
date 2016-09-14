using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213
{
    public partial class CompleteSale : Form
    {
        public salesForm f1 = new salesForm();
        public CompleteSale()
        {
            InitializeComponent();
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCompleteSalePaid_Click(object sender, EventArgs e)
        {
            
            //SqlConnection conString = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
            //SqlCommand createSale = new SqlCommand(@"INSERT INTO Sales VALUES()");
        }

        private void CompleteSale_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
            //lblTotal.Text = "The total cost: R" + Convert.ToString(f1.totalCost);
        }
    }
}
