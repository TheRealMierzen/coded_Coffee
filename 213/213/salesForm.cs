using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _213
{
    public partial class salesForm : Form
    {
        public salesForm()
        {
            InitializeComponent();
        }

        private void cmbSalesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           // SqlConnection conString = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
           // SqlCommand createSale = new SqlCommand();
           if(cmbSalesMenu.SelectedIndex == 0)
            {
                pnlAddSale.Show();
                pnlPrevSaleCancel.Hide();
            }
            if (cmbSalesMenu.SelectedIndex == 1)
            {
                pnlPrevSaleCancel.Show();
                pnlAddSale.Hide();
            }
            if (cmbSalesMenu.SelectedIndex == 2)
            {
                //Gaan na Dyl se stock search form..
            }
            if (cmbSalesMenu.SelectedIndex == 3)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            if (cmbSalesMenu.SelectedIndex == 4)
            {
                Application.Exit();
            }


        }

        private void salesForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSalesBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void salesForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_stockI_TDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this._stockI_TDataSet.Sales);
            // TODO: This line of code loads data into the '_stockI_TDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this._stockI_TDataSet.Stock);

        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {

        }

        private void lbxSaleReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaleSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
