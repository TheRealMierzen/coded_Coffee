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
    public partial class StockFindForm : Form
    {
        private string userNme;
        public StockFindForm()
        {
            InitializeComponent();
        }

        public StockFindForm(string user)
        {
            InitializeComponent();
            userNme = user;
        }

        private void txtFindName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelFind_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            //StockMainFormCLN frmStockMain = new StockMainFormCLN();
           // frmStockMain.Show();
        }

        private void btnConfirmFind_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtFindName.Text == "" & txtFindBrand.Text == "" & txtFindPrice.Text == "")
                {
                    MessageBox.Show("Please select a value");
                }
                else if(txtFindName.Text != "")
                {
                    SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    stockConnection.Open();
                    SqlDataAdapter stockDataAdapter = new SqlDataAdapter("SELECT branch, description, manufacturer, retail_price FROM Stock WHERE description LIKE '%" + txtFindName.Text + "%'", stockConnection);
                    DataSet ds = new DataSet();
                    stockDataAdapter.Fill(ds, "Stock");
                    stockConnection.Close();
                    dgvFindStock.DataSource = ds;
                    dgvFindStock.DataMember = "Stock";
                }
                else if (txtFindBrand.Text != "")
                {
                    SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    stockConnection.Open();
                    SqlDataAdapter stockDataAdapter = new SqlDataAdapter("SELECT branch, description, manufacturer, retail_price FROM Stock WHERE manufacturer LIKE '%" + txtFindBrand.Text + "%'", stockConnection);
                    DataSet ds = new DataSet();
                    stockDataAdapter.Fill(ds, "Stock");
                    stockConnection.Close();
                    dgvFindStock.DataSource = ds;
                    dgvFindStock.DataMember = "Stock";
                }
                else if (txtFindPrice.Text != "")
                {
                    string price = "R" + txtFindPrice.Text;
                    SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    stockConnection.Open();
                    SqlDataAdapter stockDataAdapter = new SqlDataAdapter("SELECT branch, description, manufacturer, retail_price FROM Stock WHERE retail_price LIKE '" + price + "'", stockConnection);
                    DataSet ds = new DataSet();
                    stockDataAdapter.Fill(ds, "Stock");
                    stockConnection.Close();
                    dgvFindStock.DataSource = ds;
                    dgvFindStock.DataMember = "Stock";
                }



                //as user ja se
                //   this.Hide();
                ///  this.Close();
                // StockMainFormCLN frmStockMain = new StockMainFormCLN();
                //frmStockMain.Show();
            }
            else
            {
                //as user nee se

            }
        }

        private void tmrValidateFind_Tick(object sender, EventArgs e)
        {
            if (txtFindName.Text == "" & txtFindBrand.Text == "" & txtFindPrice.Text == "")
            {
                txtFindBrand.Enabled = true;
                txtFindName.Enabled = true;
                txtFindPrice.Enabled = true;
            }
            if (txtFindName.Text != "")
            {
                txtFindBrand.Enabled = false;
                txtFindPrice.Enabled = false;
            }
            if (txtFindBrand.Text != "")
            {
                txtFindName.Enabled = false;
                txtFindPrice.Enabled = false;
            }
            if (txtFindPrice.Text != "")
            {
                txtFindBrand.Enabled = false;
                txtFindName.Enabled = false;
            }
        }

        private void StockFindForm_Shown(object sender, EventArgs e)
        {
            tmrValidateFind.Enabled = true;
        }

        private void txtFindPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lblFindName_Click(object sender, EventArgs e)
        {

        }
    }
}
