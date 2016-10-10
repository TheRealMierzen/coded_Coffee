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
        private int count;
        //User name
        private string userNme;
        //Default Constructor
        public StockAddFormCLN()
        {
            InitializeComponent();
        }
        //Overloaded constructor
        public StockAddFormCLN(string user)
        {
            InitializeComponent();
            userNme = user;
        }

        //Clears all the textboxes
        private void btnCancelAddCLN_Click(object sender, EventArgs e)
        {
            txbItemID.Clear();
            txbBrandAddCLN.Clear();
            txbDescAddCLN.Clear();
            txbPriceRetailAddCLN.Clear();
            txtManfacturerPriceCLN.Clear();
        }
        //Add new stock in database
        private void btnConfirmAddCLN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Stock Connection String
                    SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                    stockConnection.Open();
                    count = 0;
                    //Set Variables
                    string branchAddCLN = cmbTypeAddCLN.SelectedItem.ToString();
                    string manufacturerAddCLN = txbBrandAddCLN.Text;
                    string branchAdd = Properties.Settings.Default.Branch;
                    string warrantyAddCLN = cmbWarrantyADD.SelectedItem.ToString() + " Year(s)";
                    string mPriceAddCLN = (txtManfacturerPriceCLN.Text);
                    string rPriceAddCLN = (txbPriceRetailAddCLN.Text);
                    string descAddCLN = txbDescAddCLN.Text;
                    string status = "In Stock";
                    int check = 0;

                    SqlCommand getDes = new SqlCommand("SELECT cms_id, cms_order, cms_email, cms_itemIDs, cms_items FROM Cms WHERE branch = @branch AND completed = @com", stockConnection);
                    getDes.Parameters.AddWithValue("@com", 0);
                    getDes.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                    if (getDes.ExecuteScalar() != null)
                    {
                        SqlDataReader reader = getDes.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string l = reader.GetString(1);
                                string ids = reader.GetString(3);
                                string names = reader.GetString(4);
                                string n = descAddCLN;
                                string des = "";
                                des = reader.GetString(1);
                                if (des.Contains(descAddCLN) && (l != ""))
                                {
                                    
                                    MessageBox.Show("This item is needed for a custom build and will be added to custom builds", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    SqlCommand stockAddCommandCLN = new SqlCommand("INSERT INTO Stock(branch, item_id, manufacturer, warranty, last_updated, initial_add, manufacturer_price, retail_price, item_name, item_Type, status, checked) VALUES(@branch, @item_id, @manufacturer, @warrenty, @last_updated, @intial_add, @manufacuter_price, @retail_price, @description, @item_Type, @status, @checked)", stockConnection);
                                    stockAddCommandCLN.Parameters.AddWithValue("@branch", branchAdd);
                                    stockAddCommandCLN.Parameters.AddWithValue("@item_id", txbItemID.Text);
                                    stockAddCommandCLN.Parameters.AddWithValue("@manufacturer", manufacturerAddCLN);
                                    stockAddCommandCLN.Parameters.AddWithValue("@warrenty", warrantyAddCLN);
                                    stockAddCommandCLN.Parameters.AddWithValue("@last_updated", DateTime.Now);
                                    stockAddCommandCLN.Parameters.AddWithValue("@intial_add", DateTime.Today.ToShortDateString());
                                    stockAddCommandCLN.Parameters.AddWithValue("@manufacuter_price", mPriceAddCLN);
                                    stockAddCommandCLN.Parameters.AddWithValue("@retail_price", rPriceAddCLN);
                                    stockAddCommandCLN.Parameters.AddWithValue("@description", descAddCLN);
                                    stockAddCommandCLN.Parameters.AddWithValue("@item_Type", branchAddCLN);
                                    status = reader.GetString(0);
                                    ids = ids + txbItemID.Text + ",";
                                    names = names + descAddCLN + ",";
                                    stockAddCommandCLN.Parameters.AddWithValue("@status", status);
                                    stockAddCommandCLN.Parameters.AddWithValue("@checked", check);
                                    gebruik.addAction(userNme);
                                    gebruik.log(DateTime.Now, userNme, "Added stock" + txbItemID.Text + ", Item name: " + descAddCLN);
                                    //string meh = l.Replace(n, "");
                                    string meh = reader.GetString(1);
                                    meh = meh.Remove(meh.IndexOf(descAddCLN), descAddCLN.Length + 1);
                                    SqlCommand updateCms = new SqlCommand("UPDATE Cms SET cms_orders = @order, date_complete = @date, complete = @com, cms_itemIDs = @ids, cms_items = @items WHERE cms_id = @id");
                                    updateCms.Parameters.AddWithValue("@ids", ids);
                                    updateCms.Parameters.AddWithValue("@items", names);
                                    updateCms.Parameters.AddWithValue("@order", meh);
                                    updateCms.Parameters.AddWithValue("@id", reader.GetString(0));
                                    updateCms.Parameters.AddWithValue("@date", DateTime.Now);
                                    updateCms.Parameters.AddWithValue("@com", 1);
                                    updateCms.ExecuteNonQuery();
                                    bool test = false;
                                    if (l == "")
                                    {
                                        gebruik m = new gebruik();
                                        test = m.Mail(reader.GetString(2), "Matrix Custom Builds", "Hi there. \r\n Matrix Warehouse would like to inform you that your custom build is ready for pickup\r\nReferance number: " + reader.GetString(0) + "\r\nKeep this referance number for later use. \r\nThank you for shopping with matrix warehouse.");
                                        if (test)
                                        {

                                            MessageBox.Show("Custom build: " + reader.GetString(0) + " The client has been notified for pickup");


                                        }


                                    }
                                }
                                else
                                {
                                    //SQL Insert Command
                                    SqlCommand stockCount = new SqlCommand("SELECT COUNT(item_id) FROM Stock", stockConnection);
                                    int currentS = Convert.ToInt16(stockCount.ExecuteScalar());
                                    SqlCommand stockCap = new SqlCommand("SELECT branch_capacity FROM branches WHERE branch_location = @location", stockConnection);
                                    stockCap.Parameters.AddWithValue("@location", "Pretoria");
                                    //stockCap.Parameters.AddWithValue("@location", Properties.Settings.Default.Branch);
                                    int currentC = Convert.ToInt32(stockCap.ExecuteScalar());

                                    if (currentS < currentC)
                                    {
                                        SqlCommand stockAddCommandCLN = new SqlCommand("INSERT INTO Stock(branch, item_id, manufacturer, warranty, last_updated, initial_add, manufacturer_price, retail_price, item_name, item_Type, status, checked) VALUES(@branch, @item_id, @manufacturer, @warrenty, @last_updated, @intial_add, @manufacuter_price, @retail_price, @description, @item_Type, @status, @checked)", stockConnection);
                                        stockAddCommandCLN.Parameters.AddWithValue("@branch", branchAdd);
                                        stockAddCommandCLN.Parameters.AddWithValue("@item_id", txbItemID.Text);
                                        stockAddCommandCLN.Parameters.AddWithValue("@manufacturer", manufacturerAddCLN);
                                        stockAddCommandCLN.Parameters.AddWithValue("@warrenty", warrantyAddCLN);
                                        stockAddCommandCLN.Parameters.AddWithValue("@last_updated", DateTime.Now);
                                        stockAddCommandCLN.Parameters.AddWithValue("@intial_add", DateTime.Today);
                                        stockAddCommandCLN.Parameters.AddWithValue("@manufacuter_price", mPriceAddCLN);
                                        stockAddCommandCLN.Parameters.AddWithValue("@retail_price", rPriceAddCLN);
                                        stockAddCommandCLN.Parameters.AddWithValue("@description", descAddCLN);
                                        stockAddCommandCLN.Parameters.AddWithValue("@item_Type", branchAddCLN);
                                        stockAddCommandCLN.Parameters.AddWithValue("@status", status);
                                        stockAddCommandCLN.Parameters.AddWithValue("@checked", check);
                                        gebruik.addAction(userNme);
                                        //  gebruik.log(DateTime.Now, userNme, "Added stock" + txbItemID.Text + ", Item name: " + descAddCLN);
                                        //Clear textboxes
                                        stockAddCommandCLN.ExecuteNonQuery();
                                        stockConnection.Close();
                                        txbBrandAddCLN.Clear();
                                        txbDescAddCLN.Clear();
                                        txbPriceRetailAddCLN.Clear();
                                        cmbWarrantyADD.SelectedItem = null;
                                        cmbTypeAddCLN.SelectedItem = null;
                                        txtManfacturerPriceCLN.Clear();
                                        //Display message

                                        MessageBox.Show("Item added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                        else
                        {

                        }
                        reader.Close();
                    }
                    else
                    {
                        //SQL Insert Command
                        SqlCommand stockCount = new SqlCommand("SELECT COUNT(item_id) FROM Stock", stockConnection);
                        int currentS = Convert.ToInt16(stockCount.ExecuteScalar());
                        SqlCommand stockCap = new SqlCommand("SELECT branch_capacity FROM branches WHERE branch_location = @location", stockConnection);
                        stockCap.Parameters.AddWithValue("@location", "Pretoria");
                        //stockCap.Parameters.AddWithValue("@location", Properties.Settings.Default.Branch);
                        int currentC = Convert.ToInt32(stockCap.ExecuteScalar());

                        if (currentS < currentC)
                        {
                            SqlCommand stockAddCommandCLN = new SqlCommand("INSERT INTO Stock(branch, item_id, manufacturer, warranty, last_updated, initial_add, manufacturer_price, retail_price, item_name, item_Type, status, checked) VALUES(@branch, @item_id, @manufacturer, @warrenty, @last_updated, @intial_add, @manufacuter_price, @retail_price, @description, @item_Type, @status, @checked)", stockConnection);
                            stockAddCommandCLN.Parameters.AddWithValue("@branch", branchAdd);
                            stockAddCommandCLN.Parameters.AddWithValue("@item_id", txbItemID.Text);
                            stockAddCommandCLN.Parameters.AddWithValue("@manufacturer", manufacturerAddCLN);
                            stockAddCommandCLN.Parameters.AddWithValue("@warrenty", warrantyAddCLN);
                            stockAddCommandCLN.Parameters.AddWithValue("@last_updated", DateTime.Now);
                            stockAddCommandCLN.Parameters.AddWithValue("@intial_add", DateTime.Today);
                            stockAddCommandCLN.Parameters.AddWithValue("@manufacuter_price", mPriceAddCLN);
                            stockAddCommandCLN.Parameters.AddWithValue("@retail_price", rPriceAddCLN);
                            stockAddCommandCLN.Parameters.AddWithValue("@description", descAddCLN);
                            stockAddCommandCLN.Parameters.AddWithValue("@item_Type", branchAddCLN);
                            stockAddCommandCLN.Parameters.AddWithValue("@status", status);
                            stockAddCommandCLN.Parameters.AddWithValue("@checked", check);
                            gebruik.addAction(userNme);
                            //  gebruik.log(DateTime.Now, userNme, "Added stock" + txbItemID.Text + ", Item name: " + descAddCLN);
                            //Clear textboxes
                            stockAddCommandCLN.ExecuteNonQuery();
                            stockConnection.Close();
                            txbBrandAddCLN.Clear();
                            txbDescAddCLN.Clear();
                            cmbWarrantyADD.SelectedItem = null;
                            cmbTypeAddCLN.SelectedItem = null;
                            txtManfacturerPriceCLN.Clear();
                            //Display message

                            MessageBox.Show("Item added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Branch does not have enough capacity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
                catch (SqlException s)
                {
                    if (s.Number == 2627)
                    {
                        MessageBox.Show("Error: Duplicate IDs" + s.TargetSite, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if(s.Number == 53)
                    {
                        gebruik other = new gebruik();
                        if (other.CheckConnection() && count < 4)
                        {
                            count = count + 1;
                            btnConfirmAddCLN.PerformClick();
                        }
                        if(count == 3)
                            MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    else
                    {
                        MessageBox.Show("Error in database" + s.TargetSite, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (NullReferenceException s)
                {
                    MessageBox.Show("Error: Please fill in all the fields" + s.TargetSite, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (InvalidOperationException s)
                {
                    MessageBox.Show("Error: Invalid Operation" + s.TargetSite, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

       

        private void StockAddFormCLN_Shown(object sender, EventArgs e)
        {

        }

        private void txbQuantityAddCLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disables user to add text
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

        }

        private void txbPriceRetailAddCLN_TextChanged(object sender, EventArgs e)
        {
            if (cmbTypeAddCLN.Text != "" & cmbWarrantyADD.Text != "" & txtManfacturerPriceCLN.Text != "" & txbBrandAddCLN.Text != "" & txbDescAddCLN.Text != "")
            {
                btnConfirmAddCLN.Enabled = true;
            }
            else
            {
                btnConfirmAddCLN.Enabled = false;
            }
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

        private void txbWarrantyAddCLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txbDescAddCLN_TextChanged(object sender, EventArgs e)
        {
            if(cmbTypeAddCLN.Text != "" & cmbWarrantyADD.Text != "" & txtManfacturerPriceCLN.Text != "" & txbBrandAddCLN.Text != "" & txbDescAddCLN.Text != "")
            {
                btnConfirmAddCLN.Enabled = true;
            }
            else
            {
                btnConfirmAddCLN.Enabled = false;
            }
        }

        private void txbBrandAddCLN_TextChanged(object sender, EventArgs e)
        {
            if (cmbTypeAddCLN.Text != "" & cmbWarrantyADD.Text != "" & txtManfacturerPriceCLN.Text != "" & txbBrandAddCLN.Text != "" & txbDescAddCLN.Text != "")
            {
                btnConfirmAddCLN.Enabled = true;
            }
            else
            {
                btnConfirmAddCLN.Enabled = false;
            }
        }

        private void txtManfacturerPriceCLN_TextChanged(object sender, EventArgs e)
        {
            if (cmbTypeAddCLN.Text != "" & cmbWarrantyADD.Text != "" & txtManfacturerPriceCLN.Text != "" & txbBrandAddCLN.Text != "" & txbDescAddCLN.Text != "")
            {
                btnConfirmAddCLN.Enabled = true;
            }
            else
            {
                btnConfirmAddCLN.Enabled = false;
            }
        }

        private void txbWarrantyAddCLN_TextChanged(object sender, EventArgs e)
        {
            if (cmbTypeAddCLN.Text != "" & cmbWarrantyADD.Text != "" & txtManfacturerPriceCLN.Text != "" & txbBrandAddCLN.Text != "" & txbDescAddCLN.Text != "")
            {
                btnConfirmAddCLN.Enabled = true;
            }
            else
            {
                btnConfirmAddCLN.Enabled = false;
            }
        }

        private void cmbTypeAddCLN_TextChanged(object sender, EventArgs e)
        {
            if (cmbTypeAddCLN.Text != "" & cmbWarrantyADD.Text != "" & txtManfacturerPriceCLN.Text != "" & txbBrandAddCLN.Text != "" & txbDescAddCLN.Text != "")
            {
                btnConfirmAddCLN.Enabled = true;
            }
            else
            {
                btnConfirmAddCLN.Enabled = false;
            }
        }

        private void txbItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbItemID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
