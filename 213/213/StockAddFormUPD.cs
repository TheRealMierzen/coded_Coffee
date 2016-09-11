using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;

namespace _213
{
    public partial class StockAddFormUPD : Form
    {
        public StockAddFormUPD()
        {
            InitializeComponent();
        }

        private void txbQuantityAddUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txbQuantityAddUPD_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbListItemsAddUPD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txbRPriceUPD.Enabled = true;
        }

        private void btnConfirmAddCLN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                stockConnection.Open();
                SqlCommand updateStock = new SqlCommand("UPDATE Stock SET  retial_price = '" + Convert.ToInt16(txbRPriceUPD.Text) + "', last_updated = GETDATE() WHERE description = '" + cmbListItemsAddUPD.Text +"'", stockConnection);
                updateStock.ExecuteNonQuery();
                SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE description = '" + cmbListItemsAddUPD.Text + "'", stockConnection);
                string itemID = getID.ExecuteScalar().ToString();
                stockConnection.Close();
                this.Hide();
                this.Close();
                string message = ("Stock updated: \r\n Item ID: " + itemID + "\r\n" + "Item Description: " + cmbListItemsAddUPD.Text + "\r\n" + "Date updated: " + DateTime.Now.ToString());
                StockMainFormCLN frmStockMain = new StockMainFormCLN(message);
                frmStockMain.Show();
            }
            else
            {
                //as user nee se

            }
        }

        private void btnCancelAddCLN_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            StockMainFormCLN frmStockMain = new StockMainFormCLN();
            frmStockMain.Show();
        }

        private void StockAddFormUPD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_stockI_TDataSet.Stock' table. You can move, or remove it, as needed.
           // this.stockTableAdapter.Fill(this._stockI_TDataSet.Stock);

        }

        private void tmrCheckSelectedItemUPD_Tick(object sender, EventArgs e)
        {
           
        }

        private void cmbListItemsAddUPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListItemsAddUPD.SelectedIndex > -1)
            {
                string itemName = cmbListItemsAddUPD.Text;
                SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                stockConnection.Open();
                SqlCommand displaySelectedStockBrand = new SqlCommand("SELECT manufacturer FROM Stock WHERE description = '" + cmbListItemsAddUPD.Text + "'", stockConnection);
                SqlCommand displaySelectedStockMPrice = new SqlCommand("SELECT manufacuter_price FROM Stock WHERE description = '" + cmbListItemsAddUPD.Text + "'", stockConnection);
                SqlCommand displaySelectedStockRPrice = new SqlCommand("SELECT retail_price FROM Stock WHERE description = '" + cmbListItemsAddUPD.Text + "'", stockConnection);
              //  SqlCommand displaySelectedStockQuantity = new SqlCommand("SELECT quantity FROM Stock WHERE description = '" + cmbListItemsAddUPD.Text + "'", stockConnection);
                txbBrandAddUPD.Text = displaySelectedStockBrand.ExecuteScalar().ToString();
                txbMPriceAddUPD.Text = displaySelectedStockMPrice.ExecuteScalar().ToString();
                txbRPriceUPD.Text = displaySelectedStockRPrice.ExecuteScalar().ToString();
              //  txbQuantityAddUPD.Text = displaySelectedStockQuantity.ExecuteScalar().ToString();
                stockConnection.Close();
               
            }
        }
    }
}
