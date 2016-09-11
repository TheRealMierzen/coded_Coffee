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
    public partial class StockAddFormCLN : Form
    {
        public StockAddFormCLN()
        {
            InitializeComponent();
        }

        private void btnCancelAddCLN_Click(object sender, EventArgs e)
        {
            //Close die form en redirect terug na main Stock form
            this.Hide();
            this.Close();
            StockMainFormCLN frmStockMain = new StockMainFormCLN();
            frmStockMain.Show();
        }

        private void btnConfirmAddCLN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                stockConnection.Open();
                //SqlDataAdapter stockAddAdapterCLN = new SqlDataAdapter();
                SqlCommand getStockCountCLN = new SqlCommand("SELECT COUNT(item_id) FROM Stock",stockConnection);
                int TotalItems = 0;
                //stockAddAdapterCLN.SelectCommand = getStockCountCLN;
                TotalItems = Convert.ToInt16(getStockCountCLN.ExecuteScalar()) + 1;

                string branchAddCLN = cmbBranchAddCLN.SelectedItem.ToString();
                string manufacturerAddCLN = txbBrandAddCLN.Text;

                string warrantyAddCLN = txbWarrantyAddCLN.Text;
                string mPriceAddCLN = ("R" + txtManfacturerPriceCLN.Text);
                string rPriceAddCLN = ("R" + txbPriceRetailAddCLN.Text);
                string descAddCLN = txbDescAddCLN.Text;
                SqlCommand stockAddCommandCLN = new SqlCommand("INSERT INTO Stock VALUES('"+ branchAddCLN +"','"+TotalItems+"','"+ manufacturerAddCLN + "','" +warrantyAddCLN+ "',GETDATE(), GETDATE(),'" + mPriceAddCLN + "','" + rPriceAddCLN + "','" + descAddCLN + "')",stockConnection);
                stockAddCommandCLN.ExecuteNonQuery();
                stockConnection.Close();
                string message = ("Stock Add: \r\n Item ID: "+TotalItems + "\r\n" + "Item Description: " + descAddCLN + "\r\n" + "Date Added: " + DateTime.Now.ToString());
                this.Hide();
                this.Close();
                StockMainFormCLN frmStockMain = new StockMainFormCLN(message);
                frmStockMain.Show();
            }
            else
            {
                //as user nee se

            }

        }

       

        private void StockAddFormCLN_Shown(object sender, EventArgs e)
        {
            tmrStockAddCLN.Enabled = true;
        }

        private void txbQuantityAddCLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lblPriceRetailAddCLN_Click(object sender, EventArgs e)
        {

        }

        private void StockAddFormCLN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_stockI_TDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this._stockI_TDataSet.Branches);

        }
    }
}
