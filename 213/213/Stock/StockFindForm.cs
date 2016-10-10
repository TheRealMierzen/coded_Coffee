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
        //Class variables
        private string userNme;
        private int count;
        //Default constructor
        public StockFindForm()
        {
            InitializeComponent();
        }
        //Overloaded constructor
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
        }

        private void btnConfirmFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtFindName.Text == "" & txtFindBrand.Text == "" & txtFindPrice.Text == "" & cmbTypeSearch.Text == "")
                    {
                        MessageBox.Show("Please select a value");
                    }
                    else if (txtFindName.Text != "")
                    {
                        SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");

                        stockConnection.Open();
                        count = 0;
                        SqlDataAdapter stockDataAdapter = new SqlDataAdapter("SELECT branch, item_name, manufacturer, retail_price, item_Type FROM STOCK WHERE item_name LIKE @description", stockConnection);
                        stockDataAdapter.SelectCommand.Parameters.AddWithValue("@description", "%" + txtFindName.Text + "%");
                        DataSet ds = new DataSet();
                        stockDataAdapter.Fill(ds, "Stock");
                        stockConnection.Close();
                        dgvFindStock.DataSource = ds;
                        dgvFindStock.DataMember = "Stock";
                    }
                    else if (txtFindBrand.Text != "")
                    {
                        SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                        stockConnection.Open();
                        count = 0;
                        SqlCommand stockM = new SqlCommand("SELECT branch, item_name, manufacturer, retail_price, item_Type FROM STOCK WHERE manufacturer LIKE @description");
                        SqlDataAdapter stockDataAdapter = new SqlDataAdapter(stockM.CommandText, stockConnection);
                        stockDataAdapter.SelectCommand.Parameters.AddWithValue("@description", "%" + txtFindBrand.Text + "%");
                        DataSet ds = new DataSet();
                        stockDataAdapter.Fill(ds, "Stock");
                        stockConnection.Close();
                        dgvFindStock.DataSource = ds;
                        dgvFindStock.DataMember = "Stock";
                    }
                    else if (txtFindPrice.Text != "")
                    {
                        string price = txtFindPrice.Text;
                        SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");

                        stockConnection.Open();
                        count = 0;
                        SqlCommand stockP = new SqlCommand("SELECT branch, item_name, manufacturer, retail_price, item_Type FROM STOCK WHERE retail_price LIKE @description");

                        SqlDataAdapter stockDataAdapter = new SqlDataAdapter(stockP.CommandText, stockConnection);
                        stockDataAdapter.SelectCommand.Parameters.AddWithValue("@description", "%" + price + "%");
                        DataSet ds = new DataSet();
                        stockDataAdapter.Fill(ds, "Stock");
                        stockConnection.Close();
                        dgvFindStock.DataSource = ds;
                        dgvFindStock.DataMember = "Stock";
                    }
                    else if (cmbTypeSearch.Text != "")
                    {
                        SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                        stockConnection.Open();
                        count = 0;
                        SqlCommand stockP = new SqlCommand("SELECT branch, item_name, manufacturer, retail_price, item_Type FROM STOCK WHERE item_Type LIKE @description");

                        SqlDataAdapter stockDataAdapter = new SqlDataAdapter(stockP.CommandText, stockConnection);
                        stockDataAdapter.SelectCommand.Parameters.AddWithValue("@description", "%" + cmbTypeSearch.Text + "%");
                        DataSet ds = new DataSet();
                        stockDataAdapter.Fill(ds, "Stock");
                        stockConnection.Close();
                        dgvFindStock.DataSource = ds;
                        dgvFindStock.DataMember = "Stock";
                    }
                }
            }
            catch (SqlException s)
            {
                if (s.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count = count + 1;
                        btnConfirmFind.PerformClick();
                    }
                    else
                        MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in valid info" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void tmrValidateFind_Tick(object sender, EventArgs e)
        {
            if (txtFindName.Text == "" & txtFindBrand.Text == "" & txtFindPrice.Text == "" & cmbTypeSearch.Text == "")
            {
                txtFindBrand.Enabled = true;
                txtFindName.Enabled = true;
                txtFindPrice.Enabled = true;
                cmbTypeSearch.Enabled = true;
            }
            if (txtFindName.Text != "")
            {
                txtFindBrand.Enabled = false;
                txtFindPrice.Enabled = false;
                cmbTypeSearch.Enabled = false;
            }
            if (txtFindBrand.Text != "")
            {
                txtFindName.Enabled = false;
                txtFindPrice.Enabled = false;
                cmbTypeSearch.Enabled = false;
            }
            if (txtFindPrice.Text != "")
            {
                txtFindBrand.Enabled = false;
                txtFindName.Enabled = false;
                cmbTypeSearch.Enabled = false;
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
