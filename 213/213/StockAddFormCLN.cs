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
        private string userNme;
        public StockAddFormCLN()
        {
            InitializeComponent();
        }
        public StockAddFormCLN(string user)
        {
            InitializeComponent();
            userNme = user;
        }

        private void btnCancelAddCLN_Click(object sender, EventArgs e)
        {
            //Close die form en redirect terug na main Stock form
            txbBrandAddCLN.Clear();
            txbDescAddCLN.Clear();
            txbPriceRetailAddCLN.Clear();
            txbWarrantyAddCLN.Clear();
            txtManfacturerPriceCLN.Clear();
          //  StockMainFormCLN frmStockMain = new StockMainFormCLN();
        //    frmStockMain.Show();
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

                string branchAddCLN = cmbTypeAddCLN.SelectedItem.ToString();
                string manufacturerAddCLN = txbBrandAddCLN.Text;

                string warrantyAddCLN = txbWarrantyAddCLN.Text;
                string mPriceAddCLN = ("R" + txtManfacturerPriceCLN.Text);
                string rPriceAddCLN = ("R" + txbPriceRetailAddCLN.Text);
                string descAddCLN = txbDescAddCLN.Text;
                SqlCommand stockAddCommandCLN = new SqlCommand("INSERT INTO Stock VALUES('"+ "Pretoria" +"','"+TotalItems+"','"+ manufacturerAddCLN + "','" +warrantyAddCLN+ "',GETDATE(), GETDATE(),'" + mPriceAddCLN + "','" + rPriceAddCLN + "','" + descAddCLN + "', '"+ cmbTypeAddCLN.Text +"', 'In Stock')",stockConnection);
                SqlCommand getUserActions = new SqlCommand("Select numberOfActions FROM Users WHERE userName = '"+ userNme +"'", stockConnection);
                int count = Convert.ToInt16(getUserActions.ExecuteScalar());
                count = count + 1;
                SqlCommand updateUserActions = new SqlCommand("UPDATE Users SET numberOfActions = '"+count+"' WHERE userName = '" + userNme + "'", stockConnection);
                updateUserActions.ExecuteNonQuery();
                stockAddCommandCLN.ExecuteNonQuery();
                stockConnection.Close();
                txbBrandAddCLN.Clear();
                txbDescAddCLN.Clear();
                txbPriceRetailAddCLN.Clear();
                txbWarrantyAddCLN.Clear();
                txtManfacturerPriceCLN.Clear();
                MessageBox.Show("Item added successfully");
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
            // TODO: This line of code loads data into the '_stockI_TDataSet.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this._stockI_TDataSet.Stock);
            // TODO: This line of code loads data into the '_stockI_TDataSet.Branches' table. You can move, or remove it, as needed.
            //this.branchesTableAdapter.Fill(this._stockI_TDataSet.Branches);

        }

        private void txbPriceRetailAddCLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPriceRetailAddCLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtManfacturerPriceCLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tmrStockAddCLN_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
