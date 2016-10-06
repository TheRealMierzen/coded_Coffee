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
using System.IO;

namespace _213
{
    public partial class frmHQSearch : Form
    {
        private SqlConnection conn;

        public frmHQSearch()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string id;

                id = txtID.Text;
                    
                if (id != "")
                {
                    conn.Open();
                    SqlCommand getItemID = new SqlCommand("Select item_id from Stock where item_id = '" + id + "'", conn);
                    id = Convert.ToString(getItemID.ExecuteScalar());

                    SqlCommand getItemName = new SqlCommand("Select item_name from Stock where item_id = '" + id + "'", conn);
                    string itemName = Convert.ToString(getItemName.ExecuteScalar());

                    SqlCommand getBranch = new SqlCommand("Select branch from Stock where item_id = '" + id + "'", conn);
                    string branch = Convert.ToString(getBranch.ExecuteScalar());

                    SqlCommand getManufacturer = new SqlCommand("Select manufacturer from Stock where item_id = '" + id + "'", conn);
                    string manufacturer = Convert.ToString(getManufacturer.ExecuteScalar());

                    SqlCommand getWarranty = new SqlCommand("Select warranty from Stock where item_id = '" + id + "'", conn);
                    string warranty = Convert.ToString(getWarranty.ExecuteScalar());

                    SqlCommand getManPrice = new SqlCommand("Select manufacturer_price from Stock where item_id = '" + id + "'", conn);
                    string manPrice = Convert.ToString(getManPrice.ExecuteScalar());

                    SqlCommand getrePrice = new SqlCommand("Select retail_price from Stock where item_id = '" + id + "'", conn);
                    string rePrice = Convert.ToString(getrePrice.ExecuteScalar());

                    SqlCommand getType = new SqlCommand("Select item_Type from Stock where item_id = '" + id + "'", conn);
                    string type = Convert.ToString(getType.ExecuteScalar());
                    conn.Close();

                    btnAccept.Enabled = true;
                    frmHQ hq = new frmHQ(id, itemName, branch, manufacturer, manPrice, rePrice, type, warranty);
                    this.Hide();
                }
                else
                    btnAccept.Enabled = false;

            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnAccept_Click();
                }
            }


        }

        private void frmHQSearch_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
