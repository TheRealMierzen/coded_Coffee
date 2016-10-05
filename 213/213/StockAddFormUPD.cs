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
        private string userNme;
        public StockAddFormUPD()
        {
            InitializeComponent();
        }
        public StockAddFormUPD(string user)
        {
            InitializeComponent();
            userNme = user;
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
                try
                {
                    SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                  //  SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    stockConnection.Open();
                    SqlCommand updateStock = new SqlCommand("UPDATE Stock SET retail_price = @retail_price, last_updated = @last_updated WHERE item_id = @description", stockConnection);
                    updateStock.Parameters.AddWithValue("@retail_price", Convert.ToInt16(txbRPriceUPD.Text));
                    updateStock.Parameters.AddWithValue("@last_updated", DateTime.Now);
                    updateStock.Parameters.AddWithValue("@description", txbIDUPD.Text);
                    updateStock.ExecuteNonQuery();
                    SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_id = @description", stockConnection);
                    getID.Parameters.AddWithValue("@description", txbIDUPD.Text);
                    string itemID = getID.ExecuteScalar().ToString();
                    gebruik.addAction(userNme);
                    gebruik.addAction(userNme);
                    //  gebruik.log(DateTime.Now, userNme, "Updated stock " + txbIDUPD.text);
                    stockConnection.Close();
                    this.Hide();
                    this.Close();
            }
                catch (SqlException s)
            {
                {
                    MessageBox.Show("Error in database", "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in the fields correctly" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



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

        }

        private void methodCall()
        {
            try
            {
                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
               // SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                stockConnection.Open();
                SqlCommand displaySelectedStockName = new SqlCommand("SELECT item_name FROM Stock WHERE item_id = @des1", stockConnection);
                displaySelectedStockName.Parameters.AddWithValue("@des1", txbIDUPD.Text);
                SqlCommand displaySelectedStockBrand = new SqlCommand("SELECT manufacturer FROM Stock WHERE item_id = @des2", stockConnection);
                displaySelectedStockBrand.Parameters.AddWithValue("@des2", txbIDUPD.Text);
                SqlCommand displaySelectedStockMPrice = new SqlCommand("SELECT manufacturer_price FROM Stock WHERE item_id = @des3", stockConnection);
                displaySelectedStockMPrice.Parameters.AddWithValue("@des3", txbIDUPD.Text);
                SqlCommand displaySelectedStockRPrice = new SqlCommand("SELECT retail_price FROM Stock WHERE item_id = @des4", stockConnection);
                displaySelectedStockRPrice.Parameters.AddWithValue("@des4", txbIDUPD.Text);

                txbBrandAddUPD.Text = displaySelectedStockBrand.ExecuteScalar().ToString();
                txbMPriceAddUPD.Text = displaySelectedStockMPrice.ExecuteScalar().ToString();
                txbRPriceUPD.Text = displaySelectedStockRPrice.ExecuteScalar().ToString();
                txbNameUPD.Text = displaySelectedStockName.ExecuteScalar().ToString();
                stockConnection.Close();
            }
            catch (SqlException s)
            {
                {
                    MessageBox.Show("Error in database", "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void txbIDUPD_TextChanged(object sender, EventArgs e)
        {
            if(txbIDUPD.Text != "")
            {
                txbRPriceUPD.Enabled = true;
            }
        }

        private void txbIDUPD_KeyPress(object sender, KeyPressEventArgs e)
        { 

        }

        private void txbIDUPD_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                methodCall();
            }
        }
    }
}
